using Microsoft.EntityFrameworkCore;
using Elite.Presentation.Models;

namespace Elite.Presentation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                
                new Category { ID = 1, Name= "Luxury",      DisplayOrder = "1" },
                new Category { ID = 2, Name = "Classic",    DisplayOrder = "2" },
                new Category { ID = 3, Name = "Sport",      DisplayOrder = "3" },
                new Category { ID = 4, Name = "Smart",      DisplayOrder = "4" }
                );
        }
        public DbSet<Category> Categories { get; set; }
    }
}
