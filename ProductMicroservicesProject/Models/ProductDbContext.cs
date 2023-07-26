using Microsoft.EntityFrameworkCore;

namespace ProductMicroservicesProject.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    }
}
