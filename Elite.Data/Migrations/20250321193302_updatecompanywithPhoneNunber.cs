﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elite.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatecompanywithPhoneNunber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "companies");
        }
    }
}
