using Domain.Domain.Models;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface ITicketService
    {

        List<Ticket> GetAllTickets();
        Ticket GetDetailsForTicket(int id);
        void CreateNewTicket(Ticket t);
        void UpdateExistingTicket(Ticket t);

        ShoppingCartDTO GetShoppingCartInfo();

        void DeleteTicket(int id);
        bool AddToShoppingCart(AddToShoppingCartDTO  item, string userId);
    }
}
