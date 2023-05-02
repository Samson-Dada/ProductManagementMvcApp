using Microsoft.EntityFrameworkCore;
using ProductManagementMvcApp.Models;

namespace ProductManagementMvcApp.Data
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var productList = new List<Product>
            {
                    new Product
                    {
                    Id = 1,
                    Name = "Tootpaste",
                    Description = "A semi solid substance for washing human mouths and teeths,",
                    InStock = true,
                    Price = 34.56m
                    },
                   new Product
                   {
                    Id = 2,
                    Name = "Liquid Soap",
                    Description = "A solid non edible liquid substance for wash or for house chores,",
                    InStock = true,
                    Price = 3.56m,
                   },
                    new Product
                    {
                    Id = 3,
                    Name = "Sponge",
                    Description = "A solid substance for washing plate, and solid surface,",
                    InStock = true,
                    Price = 34.56m
                    }
            };
            modelBuilder.Entity<Product>().HasData(productList);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> User { get; set; }
    }
}
