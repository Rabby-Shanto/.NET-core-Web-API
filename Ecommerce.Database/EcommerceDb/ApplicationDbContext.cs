using Ecommerce.Model.EcommerceDbModels;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Database.EcommerceDb
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }


    }
}
