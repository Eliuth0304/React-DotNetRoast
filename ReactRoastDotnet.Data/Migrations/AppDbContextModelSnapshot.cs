﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactRoastDotnet.Data;

#nullable disable

namespace ReactRoastDotnet.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.Cart", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.CartItem", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartId", "ProductItemId");

                    b.HasIndex("ProductItemId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.CustomRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Demo",
                            NormalizedName = "DEMO"
                        });
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductItemId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId", "ProductItemId");

                    b.HasIndex("ProductItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.ProductItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageCreator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<double?>("Ounces")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The most popular espresso drink. For those that love milk in their drinks. Made of 2 ounces of espresso and 8 ounces of steamed milk.",
                            Image = "/drinkImages/latte.jpg",
                            ImageCreator = "@taisiia_shestopal",
                            Name = "Latte",
                            Ounces = 10.0,
                            Price = 5.0m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hot espresso drinks may not be for everyone. For everyone else there is always an Iced Latte!",
                            Image = "/drinkImages/icedLatte.jpg",
                            ImageCreator = "@pariwatt",
                            Name = "Iced Latte",
                            Ounces = 10.0,
                            Price = 5.0m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cold brew infused with nitro giving it a creamy texture.",
                            Image = "/drinkImages/nitroBrew.jpg",
                            ImageCreator = "@schimiggy",
                            Name = "Nitro Cold Brew",
                            Ounces = 8.0,
                            Price = 4.5m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Coffee steeped in cold water giving it a less acidic signature and more caffeine.",
                            Image = "/drinkImages/coldBrew.jpg",
                            ImageCreator = "@pariwatt",
                            Name = "Cold Brew",
                            Ounces = 8.0,
                            Price = 4.0m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 5,
                            Description = "For those that just want a cup of hot coffee!",
                            Image = "/drinkImages/dripCoffee.jpg",
                            ImageCreator = "@andrewtneel",
                            Name = "Drip Coffee",
                            Ounces = 8.0,
                            Price = 3.5m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 6,
                            Description = "For those who want a plain coffee drink but with the taste of espresso. Made of 2 ounces of espresso and 4 ounces of hot water.",
                            Image = "/drinkImages/americano.jpg",
                            ImageCreator = "@cdib925",
                            Name = "Americano",
                            Ounces = 6.0,
                            Price = 4.0m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 7,
                            Description = "For those that prefer more of the milk foam texture. Made of 2 ounces of espresso, 2 ounces of milk foam, and 2 ounces of steamed milk.",
                            Image = "/drinkImages/cappuccino.jpg",
                            ImageCreator = "@nadyeldems",
                            Name = "Cappuccino",
                            Ounces = 6.0,
                            Price = 4.5m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 8,
                            Description = "For the coffee connoisseur.",
                            Image = "/drinkImages/espresso.jpg",
                            ImageCreator = "@nate_dumlao",
                            Name = "Espresso Shot",
                            Ounces = 1.0,
                            Price = 3.5m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 9,
                            Description = "For those who want a plain coffee drink but with the taste of espresso. Made of 2 ounces of espresso and 4 ounces of hot water.",
                            Image = "/drinkImages/cortado.jpg",
                            ImageCreator = "@relentlessjpg",
                            Name = "Cortado",
                            Ounces = 3.0,
                            Price = 3.75m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 10,
                            Description = "For those that want to taste our espresso with a whip of cream. Made of 2 ounces of espresso and 1 ounce of milk foam.",
                            Image = "/drinkImages/macchiato.jpg",
                            ImageCreator = "@13on",
                            Name = "Macchiato",
                            Ounces = 3.0,
                            Price = 3.75m,
                            Type = "Drink"
                        },
                        new
                        {
                            Id = 11,
                            Description = "For those who wished the latte had more of an espresso taste. Made of 2 ounces of espresso and 4 ounces of steam milk.",
                            Image = "/drinkImages/flatWhite.jpg",
                            ImageCreator = "@hoanvokim",
                            Name = "Flat White",
                            Ounces = 6.0,
                            Price = 4.5m,
                            Type = "Drink"
                        });
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReactRoastDotnet.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.Cart", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("ReactRoastDotnet.Data.Entities.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.CartItem", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReactRoastDotnet.Data.Entities.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.Order", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.OrderItem", b =>
                {
                    b.HasOne("ReactRoastDotnet.Data.Entities.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReactRoastDotnet.Data.Entities.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ReactRoastDotnet.Data.Entities.User", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
