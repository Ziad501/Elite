using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Elite.Data.Migrations
{
    /// <inheritdoc />
    public partial class addRecordsToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "Province", "StreetAdress" },
                values: new object[,]
                {
                    { 1, "alex", "Anker", "0322839", "123123", "alexandria", "66 saad zaghlol" },
                    { 2, "alex", "Apple", "0322838", "234234", "alexandria", "67 safeya zaghlol" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
