using Microsoft.EntityFrameworkCore;
using Elite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Elite.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Phone Cases & Covers", DisplayOrder = 1 },
                new Category { ID = 2, Name = "Screen Protectors", DisplayOrder = 2 },
                new Category { ID = 3, Name = "Chargers & Cables", DisplayOrder = 3 },
                new Category { ID = 4, Name = "Audio Accessories", DisplayOrder = 4 },
                new Category { ID = 5, Name = "Bluetooth Speakers", DisplayOrder = 5 },
                new Category { ID = 6, Name = "Lens protection", DisplayOrder = 6 },
                new Category { ID = 7, Name = "Power Banks", DisplayOrder = 7 }
                ); 
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Anker", StreetAdress = "66 saad zaghlol", City="alex", Province="alexandria", PhoneNumber="0322839",PostalCode="123123" },
                new Company { Id = 2, Name = "Apple", StreetAdress = "67 safeya zaghlol", City="alex", Province="alexandria", PhoneNumber="0322838", PostalCode="234234" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "S24 Ultra Case", Description = "A magnatic case for samsung galaxy s24 ultra, full camera protection with lens, black", Brand = "GRABIST", Price = 200, Price50 = 170, Price100 = 150, CategoryId =1, ImageUrl = "" },
                new Product { Id = 2, ProductName = "Iphone 15 pro max case", Description = "A magnatic transparent case for iphone 15 pro max case, combatible with magnatic charger", Brand = "Gtech", Price = 155, Price50 = 140, Price100 = 130, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 3, ProductName = "Oppo Find X 5 Case", Description = "A flexible silicon case for Oppo Find X 5 Case, grey", Brand = "Dalaa mobilak", Price = 175, Price50 = 150, Price100 = 140, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 4, ProductName = "Iphone 13 pro max screen protector", Description = "high quality screen protector, transparent", Brand = "JOYROOM", Price = 500, Price50 = 450, Price100 = 430, CategoryId = 2, ImageUrl = "" }
                ,
                new Product { Id = 5, ProductName = "Iphone 14 pro max screen protector", Description = "high quality screen protector, transparent", Brand = "Anker", Price = 500, Price50 = 450, Price100 = 430, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 6, ProductName = "S24 Ultra screen protector", Description = "high quality screen protector, transparent", Brand = "Generic", Price = 400, Price50 = 370, Price100 = 350 , CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 7, ProductName = "Anker Power Port 3 Charger", Description = "20W USB-C Power Supply Charging", Brand = "Anker", Price = 600, Price50 = 570, Price100 = 550 , CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 8, ProductName = "Xiaomi Charger", Description = "33W USB-C Power Supply Charging", Brand = "Xiaomi", Price = 200, Price50 = 170, Price100 = 150 , CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 9, ProductName = "Joyroom wireless charger", Description = "a Joyroom 3 in 1 wireless charger for apple products", Brand = "JOYROOM", Price = 1200, Price50 = 1170, Price100 = 1150, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 10, ProductName = "Mag Safe Charger", Description = "A wirless charger from apple.", Brand = "Apple", Price = 2200, Price50 = 2170, Price100 = 2150, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 11, ProductName = "JBL Tune 110 Earphone", Description = "black wired hand-free from jbl", Brand = "JBL", Price = 250, Price50 = 210, Price100 = 190, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 12, ProductName = "Xiaomi Redmi Buds 4 active", Description = "bluetooth 5.3, powerful bass, itelligent touch control", Brand = "GRABIST", Price = 3200, Price50 = 3170, Price100 = 3150, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 13, ProductName = "Apple AirPods 3", Description = "Premium apple Airpods with noise cancelation", Brand = "Apple", Price = 9800, Price50 = 9570, Price100 = 9150, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 14, ProductName = "Soundcore Flare 2", Description = "Bluetooth speaker with ipx7 waterproof protection, 20W ,12h playtime, black", Brand = "Anker", Price = 2000, Price50 = 1750, Price100 = 1500, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 15, ProductName = "JBL Flib 6 Portal", Description = "ip67 waterproof speaker w bold JBL original pro sound, 12h battery, 1 year warranty", Brand = "JBL", Price = 5600, Price50 = 5200, Price100 = 5100, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 16, ProductName = "JBL Go 4 Portable", Description = "ip67 waterproof 7h playtime, playtimeboost and JBL Pro Sound", Brand = "JBL", Price = 3200, Price50 = 3170, Price100 = 3150, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 17, ProductName = "S24 Ultra lens", Description = "tempered glass and ultra-thin aluminum", Brand = "GRABIST", Price = 90, Price50 = 70, Price100 = 50, CategoryId = 1 , ImageUrl = "" }
                ,
                new Product { Id = 18, ProductName = "Iphone 16 lens", Description = "tempered glass and ultra-thin aluminum", Brand = "GRABIST", Price = 200, Price50 = 170, Price100 = 150, CategoryId = 1 , ImageUrl = "" }
                ,
                new Product { Id = 19, ProductName = "samsung A54 lens", Description = "Reioo 9H tempered glass and ultra-thin aluminum", Brand = "Reioo", Price = 70, Price50 = 50, Price100 = 45, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 20, ProductName = "Anker Nano Power Bank", Description = "10.000mAh portable charger and PD 30W", Brand = "Anker", Price = 300, Price50 = 270, Price100 = 250, CategoryId = 1, ImageUrl = "" }
                ,
                new Product { Id = 21, ProductName = "Xiaomi Redmi Power Bank", Description = "10.000mAh portable charger and 6-moth warranty", Brand = "Xiaomi", Price = 200, Price50 = 170, Price100 = 150, CategoryId = 1, ImageUrl="" }
                );
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
