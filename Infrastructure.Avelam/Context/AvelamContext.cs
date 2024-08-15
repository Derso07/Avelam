using ApplicationCore.Avelam.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Avelam.Context
{
    public class AvelamContext : DbContext
    {
        public AvelamContext(DbContextOptions<AvelamContext> options) : base(options) 
        { 
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sweet> Sweets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
