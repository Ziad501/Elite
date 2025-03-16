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
                new Category { ID = 1, Name = "Classic", DisplayOrder = "1" },
                new Category { ID = 2, Name = "Sports", DisplayOrder = "2" },
                new Category { ID = 3, Name = "Smart", DisplayOrder = "3" }
                );
        }
        public DbSet<Category> Categories { get; set; }
    }
}
