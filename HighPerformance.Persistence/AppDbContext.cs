using HighPerformance.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HighPerformance.Persistence
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity mappings
        }
    }
}