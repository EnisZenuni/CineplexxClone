using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<TicketApplicationUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<TicketApplicationUser>();
        }

        public void Delete(TicketApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public TicketApplicationUser Get(string id)
        {
            var user = entities.Include(z => z.UserShoppingCart).Include("UserShoppingCart.ProductsInShoppingCarts")
                .Include("UserShoppingCart.ProductsInShoppingCarts.Product")
                .FirstOrDefault();

            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            return user;
        }

        public IEnumerable<TicketApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(TicketApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(TicketApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
