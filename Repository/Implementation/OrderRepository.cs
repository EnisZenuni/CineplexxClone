using Domain.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{
    public class OrderRepository<T> : IOrderRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext context;
        private DbSet<Order> entities;
        string errorMessage = string.Empty;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Order>();
        }

        public List<Order> GetAllOrders()
        {
            return entities.Include(z => z.OrderedBy).Include(z => z.Tickets).Include("Tickets.Ticket").ToList();
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return entities.Include(z => z.OrderedBy).Include(z => z.Tickets).Include("Tickets.Ticket").FirstOrDefault(z => z.Id == model.Id);
        }
    }
}
