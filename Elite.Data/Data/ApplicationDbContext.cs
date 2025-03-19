using Microsoft.EntityFrameworkCore;
using Elite.Models;

namespace Elite.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Phone Cases & Covers", DisplayOrder = 1 },
                new Category { ID = 2, Name = "Screen Protectors", DisplayOrder = 2 },
                new Category { ID = 3, Name = "Chargers & Cables", DisplayOrder = 3 },
                new Category { ID = 4, Name = "Audio Accessories", DisplayOrder = 4 },
                new Category { ID = 5, Name = "Bluetooth Speakers", DisplayOrder = 5 },
                new Category { ID = 6, Name = "Lens protection", DisplayOrder = 6 },
                new Category { ID = 7, Name = "Power Banks", DisplayOrder = 7 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "S24 Ultra Case", Description = "A magnatic case for samsung galaxy s24 ultra, full camera protection with lens, black", Brand = "GRABIST", Price = 200m, Price50 = 170m, Price100 = 150m },
                new Product { Id = 2, Name = "Iphone 15 pro max case", Description = "A magnatic transparent case for iphone 15 pro max case, combatible with magnatic charger", Brand = "Gtech", Price = 155m, Price50 = 140m, Price100 = 130m }
                ,
                new Product { Id = 3, Name = "Oppo Find X 5 Case", Description = "A flexible silicon case for Oppo Find X 5 Case, grey", Brand = "Dalaa mobilak", Price = 175m, Price50 = 150m, Price100 = 140m }
                ,
                new Product { Id = 4, Name = "Iphone 13 pro max screen protector", Description = "high quality screen protector, transparent", Brand = "JOYROOM", Price = 500m, Price50 = 450m, Price100 = 430m }
                ,
                new Product { Id = 5, Name = "Iphone 14 pro max screen protector", Description = "high quality screen protector, transparent", Brand = "Anker", Price = 500m, Price50 = 450m, Price100 = 430m }
                ,
                new Product { Id = 6, Name = "S24 Ultra screen protector", Description = "high quality screen protector, transparent", Brand = "Generic", Price = 400m, Price50 = 370m, Price100 = 350m }
                ,
                new Product { Id = 7, Name = "Anker Power Port 3 Charger", Description = "20W USB-C Power Supply Charging", Brand = "Anker", Price = 600m, Price50 = 570m, Price100 = 550m }
                ,
                new Product { Id = 8, Name = "Xiaomi Charger", Description = "33W USB-C Power Supply Charging", Brand = "Xiaomi", Price = 200m, Price50 = 170m, Price100 = 150m }
                ,
                new Product { Id = 9, Name = "Joyroom wireless charger", Description = "a Joyroom 3 in 1 wireless charger for apple products", Brand = "JOYROOM", Price = 1200m, Price50 = 1170m, Price100 = 1150m }
                ,
                new Product { Id = 10, Name = "Mag Safe Charger", Description = "A wirless charger from apple.", Brand = "Apple", Price = 2200m, Price50 = 2170m, Price100 = 2150m }
                ,
                new Product { Id = 11, Name = "JBL Tune 110 Earphone", Description = "black wired hand-free from jbl", Brand = "JBL", Price = 250m, Price50 = 210m, Price100 = 190m }
                ,
                new Product { Id = 12, Name = "Xiaomi Redmi Buds 4 active", Description = "bluetooth 5.3, powerful bass, itelligent touch control", Brand = "GRABIST", Price = 3200m, Price50 = 3170m, Price100 = 3150m }
                ,
                new Product { Id = 13, Name = "Apple AirPods 3", Description = "Premium apple Airpods with noise cancelation", Brand = "Apple", Price = 9800m, Price50 = 9570m, Price100 = 9150m }
                ,
                new Product { Id = 14, Name = "Soundcore Flare 2", Description = "Bluetooth speaker with ipx7 waterproof protection, 20W ,12h playtime, black", Brand = "Anker", Price = 2000m, Price50 = 1750m, Price100 = 1500m }
                ,
                new Product { Id = 15, Name = "JBL Flib 6 Portal", Description = "ip67 waterproof speaker w bold JBL original pro sound, 12h battery, 1 year warranty", Brand = "JBL", Price = 5600m, Price50 = 5200m, Price100 = 5100m }
                ,
                new Product { Id = 16, Name = "JBL Go 4 Portable", Description = "ip67 waterproof 7h playtime, playtimeboost and JBL Pro Sound", Brand = "JBL", Price = 3200m, Price50 = 3170m, Price100 = 3150m }
                ,
                new Product { Id = 17, Name = "S24 Ultra lens", Description = "tempered glass and ultra-thin aluminum", Brand = "GRABIST", Price = 90m, Price50 = 70m, Price100 = 50m }
                ,
                new Product { Id = 18, Name = "Iphone 16 lens", Description = "tempered glass and ultra-thin aluminum", Brand = "GRABIST", Price = 200m, Price50 = 170m, Price100 = 150m }
                ,
                new Product { Id = 19, Name = "samsung A54 lens", Description = "Reioo 9H tempered glass and ultra-thin aluminum", Brand = "Reioo", Price = 70m, Price50 = 50m, Price100 = 45m }
                ,
                new Product { Id = 20, Name = "Anker Nano Power Bank", Description = "10.000mAh portable charger and PD 30W", Brand = "Anker", Price = 300m, Price50 = 270m, Price100 = 250m }
                ,
                new Product { Id = 21, Name = "Xiaomi Redmi Power Bank", Description = "10.000mAh portable charger and 6-moth warranty", Brand = "Xiaomi", Price = 200m, Price50 = 170m, Price100 = 150m }
                );
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
