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
    public class TicketService : ITicketService
    {
        public readonly IRepository<Ticket> _ticketRepository;

        public TicketService(IRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public bool AddToShoppingCart(AddToShoppingCartDTO item, string userId)
        {
            throw new NotImplementedException();
        }

        public void CreateNewTicket(Ticket t)
        {
            this._ticketRepository.Insert(t);
        }

        public void DeleteTicket(int id)
        {
            var ticket = _ticketRepository.Get(id);
            this._ticketRepository.Delete(ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return _ticketRepository.GetAll().ToList();  
        }

        public Ticket GetDetailsForTicket(int id)
        {
            return this._ticketRepository.Get(id);
        }

        public ShoppingCartDTO GetShoppingCartInfo()
        {
            throw new NotImplementedException();
        }

        public void UpdateExistingTicket(Ticket t)
        {
            this._ticketRepository.Update(t);
        }
    }
}
