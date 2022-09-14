using Domain.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    public class TicketApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; } 

        public virtual ShoppingCart UserShoppingCart { get; set; }  

    }
}
