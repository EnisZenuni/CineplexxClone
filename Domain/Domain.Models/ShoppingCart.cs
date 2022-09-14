using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Domain.Models
{
    public class ShoppingCart : BaseEntity
    {
        

        public string ApplicationUserId { get; set; }

        public ICollection<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }
    }
}
