﻿using Elite.Razor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace Elite.Razor_Temp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Phone Cases & Covers", DisplayOrder = 1 },
                new Category { ID = 2, Name = "Screen Protectors", DisplayOrder = 2 },
                new Category { ID = 3, Name = "Chargers & Cables", DisplayOrder = 3 }
                );
        }

    }
}
