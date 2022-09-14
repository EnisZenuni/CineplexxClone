using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<TicketApplicationUser> GetAll();
        TicketApplicationUser Get(string id);
        void Insert(TicketApplicationUser entity);
        void Update(TicketApplicationUser entity);
        void Delete(TicketApplicationUser entity);
    }
}
