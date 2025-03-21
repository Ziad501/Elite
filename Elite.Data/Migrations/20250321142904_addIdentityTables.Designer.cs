﻿// <auto-generated />
using System;
using Elite.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elite.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250321142904_addIdentityTables")]
    partial class addIdentityTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Elite.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DisplayOrder = 1,
                            Name = "Phone Cases & Covers"
                        },
                        new
                        {
                            ID = 2,
                            DisplayOrder = 2,
                            Name = "Screen Protectors"
                        },
                        new
                        {
                            ID = 3,
                            DisplayOrder = 3,
                            Name = "Chargers & Cables"
                        },
                        new
                        {
                            ID = 4,
                            DisplayOrder = 4,
                            Name = "Audio Accessories"
                        },
                        new
                        {
                            ID = 5,
                            DisplayOrder = 5,
                            Name = "Bluetooth Speakers"
                        },
                        new
                        {
                            ID = 6,
                            DisplayOrder = 6,
                            Name = "Lens protection"
                        },
                        new
                        {
                            ID = 7,
                            DisplayOrder = 7,
                            Name = "Power Banks"
                        });
                });

            modelBuilder.Entity("Elite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "GRABIST",
                            CategoryId = 1,
                            Description = "A magnatic case for samsung galaxy s24 ultra, full camera protection with lens, black",
                            ImageUrl = "",
                            Price = 200.0,
                            Price100 = 150.0,
                            Price50 = 170.0,
                            ProductName = "S24 Ultra Case"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Gtech",
                            CategoryId = 1,
                            Description = "A magnatic transparent case for iphone 15 pro max case, combatible with magnatic charger",
                            ImageUrl = "",
                            Price = 155.0,
                            Price100 = 130.0,
                            Price50 = 140.0,
                            ProductName = "Iphone 15 pro max case"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Dalaa mobilak",
                            CategoryId = 1,
                            Description = "A flexible silicon case for Oppo Find X 5 Case, grey",
                            ImageUrl = "",
                            Price = 175.0,
                            Price100 = 140.0,
                            Price50 = 150.0,
                            ProductName = "Oppo Find X 5 Case"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "JOYROOM",
                            CategoryId = 2,
                            Description = "high quality screen protector, transparent",
                            ImageUrl = "",
                            Price = 500.0,
                            Price100 = 430.0,
                            Price50 = 450.0,
                            ProductName = "Iphone 13 pro max screen protector"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Anker",
                            CategoryId = 1,
                            Description = "high quality screen protector, transparent",
                            ImageUrl = "",
                            Price = 500.0,
                            Price100 = 430.0,
                            Price50 = 450.0,
                            ProductName = "Iphone 14 pro max screen protector"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Generic",
                            CategoryId = 1,
                            Description = "high quality screen protector, transparent",
                            ImageUrl = "",
                            Price = 400.0,
                            Price100 = 350.0,
                            Price50 = 370.0,
                            ProductName = "S24 Ultra screen protector"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Anker",
                            CategoryId = 1,
                            Description = "20W USB-C Power Supply Charging",
                            ImageUrl = "",
                            Price = 600.0,
                            Price100 = 550.0,
                            Price50 = 570.0,
                            ProductName = "Anker Power Port 3 Charger"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Xiaomi",
                            CategoryId = 1,
                            Description = "33W USB-C Power Supply Charging",
                            ImageUrl = "",
                            Price = 200.0,
                            Price100 = 150.0,
                            Price50 = 170.0,
                            ProductName = "Xiaomi Charger"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "JOYROOM",
                            CategoryId = 1,
                            Description = "a Joyroom 3 in 1 wireless charger for apple products",
                            ImageUrl = "",
                            Price = 1200.0,
                            Price100 = 1150.0,
                            Price50 = 1170.0,
                            ProductName = "Joyroom wireless charger"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Apple",
                            CategoryId = 1,
                            Description = "A wirless charger from apple.",
                            ImageUrl = "",
                            Price = 2200.0,
                            Price100 = 2150.0,
                            Price50 = 2170.0,
                            ProductName = "Mag Safe Charger"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "JBL",
                            CategoryId = 1,
                            Description = "black wired hand-free from jbl",
                            ImageUrl = "",
                            Price = 250.0,
                            Price100 = 190.0,
                            Price50 = 210.0,
                            ProductName = "JBL Tune 110 Earphone"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "GRABIST",
                            CategoryId = 1,
                            Description = "bluetooth 5.3, powerful bass, itelligent touch control",
                            ImageUrl = "",
                            Price = 3200.0,
                            Price100 = 3150.0,
                            Price50 = 3170.0,
                            ProductName = "Xiaomi Redmi Buds 4 active"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "Apple",
                            CategoryId = 1,
                            Description = "Premium apple Airpods with noise cancelation",
                            ImageUrl = "",
                            Price = 9800.0,
                            Price100 = 9150.0,
                            Price50 = 9570.0,
                            ProductName = "Apple AirPods 3"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Anker",
                            CategoryId = 1,
                            Description = "Bluetooth speaker with ipx7 waterproof protection, 20W ,12h playtime, black",
                            ImageUrl = "",
                            Price = 2000.0,
                            Price100 = 1500.0,
                            Price50 = 1750.0,
                            ProductName = "Soundcore Flare 2"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "JBL",
                            CategoryId = 1,
                            Description = "ip67 waterproof speaker w bold JBL original pro sound, 12h battery, 1 year warranty",
                            ImageUrl = "",
                            Price = 5600.0,
                            Price100 = 5100.0,
                            Price50 = 5200.0,
                            ProductName = "JBL Flib 6 Portal"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "JBL",
                            CategoryId = 1,
                            Description = "ip67 waterproof 7h playtime, playtimeboost and JBL Pro Sound",
                            ImageUrl = "",
                            Price = 3200.0,
                            Price100 = 3150.0,
                            Price50 = 3170.0,
                            ProductName = "JBL Go 4 Portable"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "GRABIST",
                            CategoryId = 1,
                            Description = "tempered glass and ultra-thin aluminum",
                            ImageUrl = "",
                            Price = 90.0,
                            Price100 = 50.0,
                            Price50 = 70.0,
                            ProductName = "S24 Ultra lens"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "GRABIST",
                            CategoryId = 1,
                            Description = "tempered glass and ultra-thin aluminum",
                            ImageUrl = "",
                            Price = 200.0,
                            Price100 = 150.0,
                            Price50 = 170.0,
                            ProductName = "Iphone 16 lens"
                        },
                        new
                        {
                            Id = 19,
                            Brand = "Reioo",
                            CategoryId = 1,
                            Description = "Reioo 9H tempered glass and ultra-thin aluminum",
                            ImageUrl = "",
                            Price = 70.0,
                            Price100 = 45.0,
                            Price50 = 50.0,
                            ProductName = "samsung A54 lens"
                        },
                        new
                        {
                            Id = 20,
                            Brand = "Anker",
                            CategoryId = 1,
                            Description = "10.000mAh portable charger and PD 30W",
                            ImageUrl = "",
                            Price = 300.0,
                            Price100 = 250.0,
                            Price50 = 270.0,
                            ProductName = "Anker Nano Power Bank"
                        },
                        new
                        {
                            Id = 21,
                            Brand = "Xiaomi",
                            CategoryId = 1,
                            Description = "10.000mAh portable charger and 6-moth warranty",
                            ImageUrl = "",
                            Price = 200.0,
                            Price100 = 150.0,
                            Price50 = 170.0,
                            ProductName = "Xiaomi Redmi Power Bank"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Elite.Models.Product", b =>
                {
                    b.HasOne("Elite.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
