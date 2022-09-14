using Domain.Domain.Models;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation
{
    public class OrderService : IOrderService
    {
        public readonly IOrderRepository<Order> _orderRepository;

        public OrderService(IOrderRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return _orderRepository.GetOrderDetails(model);
        }
    }
}
