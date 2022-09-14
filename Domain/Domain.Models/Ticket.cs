using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Domain.Models
{
    public class Ticket : BaseEntity
    {
        
        public float TicketPrice { get; set; }
        [Required]
        [Display(Name = "Number of available Tickets: ")]
        public int TicketNo { get; set; }
        [Display(Name = "Time: ")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, MMMM d, yyyy}")]
        public DateTime dateTime { get; set; }

        public Movie Movie { get; set; }
        [ForeignKey("MovieId")]
        [Display(Name = "Movie ")]
        public int MovieId { get; set; }

        public ICollection<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }

        //public ICollection<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }

    }
}
