using Microsoft.EntityFrameworkCore;
using PhongHienCoop.Models;

namespace PhongHienCoop.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
