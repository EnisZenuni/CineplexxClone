

using Domain.Domain.Models;

namespace Domain.DTO
{
    public class AddToShoppingCartDTO
    {
        public Ticket SelectedTicket { get; set; }  
        public int TicketId { get; set; }

        public int Quantity { get; set; }


        

    }
}
