using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Domain.Models
{
    public class TicketsInShoppingCart : BaseEntity
    {
        public int TicketId { get; set; }

        public int CartId { get; set; }

        public float TicketPrice { get; set; }

        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
        [ForeignKey("CartId")]

            

        public ShoppingCart ShoppingCart { get; set; }

        public int Quantity { get; set; }


    }
}
