using Microsoft.EntityFrameworkCore;
using simulation2.Models;

namespace simulation2.DataAccesssLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions _options) : base(_options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
