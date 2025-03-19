using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Elite.Data.Migrations
{
    /// <inheritdoc />
    public partial class initWithProductsAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Phone Cases & Covers" },
                    { 2, 2, "Screen Protectors" },
                    { 3, 3, "Chargers & Cables" },
                    { 4, 4, "Audio Accessories" },
                    { 5, 5, "Bluetooth Speakers" },
                    { 6, 6, "Lens protection" },
                    { 7, 7, "Power Banks" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Price", "Price100", "Price50", "ProductName" },
                values: new object[,]
                {
                    { 1, "GRABIST", "A magnatic case for samsung galaxy s24 ultra, full camera protection with lens, black", 200.0, 150.0, 170.0, "S24 Ultra Case" },
                    { 2, "Gtech", "A magnatic transparent case for iphone 15 pro max case, combatible with magnatic charger", 155.0, 130.0, 140.0, "Iphone 15 pro max case" },
                    { 3, "Dalaa mobilak", "A flexible silicon case for Oppo Find X 5 Case, grey", 175.0, 140.0, 150.0, "Oppo Find X 5 Case" },
                    { 4, "JOYROOM", "high quality screen protector, transparent", 500.0, 430.0, 450.0, "Iphone 13 pro max screen protector" },
                    { 5, "Anker", "high quality screen protector, transparent", 500.0, 430.0, 450.0, "Iphone 14 pro max screen protector" },
                    { 6, "Generic", "high quality screen protector, transparent", 400.0, 350.0, 370.0, "S24 Ultra screen protector" },
                    { 7, "Anker", "20W USB-C Power Supply Charging", 600.0, 550.0, 570.0, "Anker Power Port 3 Charger" },
                    { 8, "Xiaomi", "33W USB-C Power Supply Charging", 200.0, 150.0, 170.0, "Xiaomi Charger" },
                    { 9, "JOYROOM", "a Joyroom 3 in 1 wireless charger for apple products", 1200.0, 1150.0, 1170.0, "Joyroom wireless charger" },
                    { 10, "Apple", "A wirless charger from apple.", 2200.0, 2150.0, 2170.0, "Mag Safe Charger" },
                    { 11, "JBL", "black wired hand-free from jbl", 250.0, 190.0, 210.0, "JBL Tune 110 Earphone" },
                    { 12, "GRABIST", "bluetooth 5.3, powerful bass, itelligent touch control", 3200.0, 3150.0, 3170.0, "Xiaomi Redmi Buds 4 active" },
                    { 13, "Apple", "Premium apple Airpods with noise cancelation", 9800.0, 9150.0, 9570.0, "Apple AirPods 3" },
                    { 14, "Anker", "Bluetooth speaker with ipx7 waterproof protection, 20W ,12h playtime, black", 2000.0, 1500.0, 1750.0, "Soundcore Flare 2" },
                    { 15, "JBL", "ip67 waterproof speaker w bold JBL original pro sound, 12h battery, 1 year warranty", 5600.0, 5100.0, 5200.0, "JBL Flib 6 Portal" },
                    { 16, "JBL", "ip67 waterproof 7h playtime, playtimeboost and JBL Pro Sound", 3200.0, 3150.0, 3170.0, "JBL Go 4 Portable" },
                    { 17, "GRABIST", "tempered glass and ultra-thin aluminum", 90.0, 50.0, 70.0, "S24 Ultra lens" },
                    { 18, "GRABIST", "tempered glass and ultra-thin aluminum", 200.0, 150.0, 170.0, "Iphone 16 lens" },
                    { 19, "Reioo", "Reioo 9H tempered glass and ultra-thin aluminum", 70.0, 45.0, 50.0, "samsung A54 lens" },
                    { 20, "Anker", "10.000mAh portable charger and PD 30W", 300.0, 250.0, 270.0, "Anker Nano Power Bank" },
                    { 21, "Xiaomi", "10.000mAh portable charger and 6-moth warranty", 200.0, 150.0, 170.0, "Xiaomi Redmi Power Bank" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
