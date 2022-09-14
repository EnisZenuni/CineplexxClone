using Domain.Domain.Models;
using System.Collections.Generic;

namespace Domain.DTO
{
    public class ShoppingCartDTO
    {
        public List<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; } 
        public float TotalPrice { get; set; }   

    }
}
