using Microsoft.EntityFrameworkCore;
using Book_store.Models;

namespace Book_store.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Action",
                    DisplayOrder = 1,
                },

                new Category
                {
                    CategoryId = 2,
                    Name = "Drama",
                    DisplayOrder = 2,
                },

                new Category
                {
                    CategoryId = 3,
                    Name = "History", 
                    DisplayOrder = 3,
                }
            );
        }
        public DbSet <Category> Categories { get; set; }
    }
}
