using Microsoft.EntityFrameworkCore;
using RepositoryPatternPractise.Models;

namespace RepositoryPatternPractise.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option) 
        {
            

            
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "phone",
                    price=123
                    
                },
                 new Product
                 {
                     Id = 2,
                     Name = "laptop",
                     price = 345

                 },
                  new Product
                  {
                      Id = 3,
                      Name = "mouse",
                      price = 66

                  }

                );
        }

    }
}
