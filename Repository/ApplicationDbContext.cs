using Domain.Domain.Models;
using Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Repository
{
    public class ApplicationDbContext : IdentityDbContext<TicketApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<TicketInOrder> TicketInOrders { get; set; }

        public DbSet<TicketApplicationUser> ticketApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TicketsInShoppingCart>().HasKey(c => new { c.CartId, c.TicketId });
            builder.Entity<TicketInOrder>().HasKey(c => new { c.OrderId, c.TicketId });
        }

        public virtual DbSet<TicketsInShoppingCart> TicketsInShoppingCarts { get; set; }
        public virtual DbSet<TicketApplicationUser> TicketApplicationUsers { get; set; }
    }
}
