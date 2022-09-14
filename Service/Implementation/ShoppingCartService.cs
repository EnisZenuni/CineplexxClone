using Domain.Domain.Models;
using Domain.DTO;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        public readonly IRepository<TicketInOrder> _ticketsInOrderRepository;
        public readonly IRepository<ShoppingCart> _shoppingCartRepository;
        public readonly IUserRepository _userRepository;
        public readonly IRepository<Order> _orderRepository;


        public ShoppingCartService(IRepository<TicketInOrder> ticketsInOrderRepository, IRepository<ShoppingCart> shoppingCartRepository, IUserRepository userRepository, IRepository<Order> orderRepository)
        {
            _ticketsInOrderRepository = ticketsInOrderRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
        }

        public bool DeleteProductFromShoppingCart(string userId, int ticketId)
        {
            if (userId != null && ticketId != null)
            {
                var loggedUser = _userRepository.Get(userId);
                var userShoppingCart = loggedUser.UserShoppingCart;
                var itemToDelete = userShoppingCart.TicketsInShoppingCarts.Where(z => z.TicketId == ticketId).FirstOrDefault();

                userShoppingCart.TicketsInShoppingCarts.Remove(itemToDelete);

                _shoppingCartRepository.Update(userShoppingCart);

                return true;
            }
            return false;
        }

        public ShoppingCartDTO GetShoppingCartInfo(string userId)
        {
            var user = _userRepository.Get(userId);

            var userShoppingCart = user.UserShoppingCart;

            var ticketsList = userShoppingCart.TicketsInShoppingCarts.Select(z => new
            {
                Quantity = z.Quantity,
                TicketPrice = z.Ticket.TicketPrice
            });

            

            float totalPrice = 0;
            foreach (var item in ticketsList)
            {
                totalPrice += item.TicketPrice * item.Quantity;
            }

            // some kind of constructor - "set method option"
            ShoppingCartDTO model = new ShoppingCartDTO
            {
                TicketsInShoppingCarts = userShoppingCart.TicketsInShoppingCarts.ToList(),
                TotalPrice = totalPrice
            };

            return model;
        }

        public bool OrderNow(string userId)
        {
            var user = _userRepository.Get(userId);

            var userShoppingCart = user.UserShoppingCart;

            Order newOrder = new Order
            {
                UserId = user.Id,
                OrderedBy = user
            };

            _orderRepository.Insert(newOrder);

            //orderId has not already been saved to the database. It will be transfered as soon as it saves. No need to save to database this soon
            List<TicketInOrder> productsInOrders = userShoppingCart.TicketsInShoppingCarts.Select(z => new TicketInOrder
            {
                Ticket = z.Ticket,
                TicketId = z.TicketId,
                Order = newOrder,
                OrderId = newOrder.Id,
                
            }).ToList();

            foreach (var item in productsInOrders)
            {
                _ticketsInOrderRepository.Insert(item);
            }

            user.UserShoppingCart.TicketsInShoppingCarts.Clear();
            _userRepository.Update(user);

            return true;
        }
    }
}
