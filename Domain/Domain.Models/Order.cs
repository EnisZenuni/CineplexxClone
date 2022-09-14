using Domain.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Domain.Models
{
    public class Order : BaseEntity
    {
     

        public string UserId { get; set; }

        public TicketApplicationUser OrderedBy { get; set; }    

        public List<TicketInOrder> Tickets { get; set; }
    }
}
