﻿// <auto-generated />
using System;
using BeautyStoreDL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BeautyStoreDL.Migrations
{
    [DbContext(typeof(BeautyStoreDBContext))]
    partial class BeautyStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.BeautyProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brands")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("InventoryInventoriesId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("integer");

                    b.Property<string>("Sizes")
                        .HasColumnType("text");

                    b.Property<string>("Types")
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.HasIndex("InventoryInventoriesId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("BeautyProducts");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BillingAddress")
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Inventory", b =>
                {
                    b.Property<int>("InventoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("InventoriesId");

                    b.HasIndex("LocationId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Item", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("ShoppingCartId", "ProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("LocationName")
                        .HasColumnType("text");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("integer");

                    b.HasKey("LocationId");

                    b.HasIndex("ManagerID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ManagerName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("ManagerID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("ManagerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte>("OrderStatus")
                        .HasColumnType("smallint");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.BeautyProduct", b =>
                {
                    b.HasOne("BeautyStore.BeautyStoreModels.Inventory", "Inventory")
                        .WithMany("BeautyProducts")
                        .HasForeignKey("InventoryInventoriesId");

                    b.HasOne("BeautyStore.BeautyStoreModels.ShoppingCart", "ShoppingCart")
                        .WithMany("BeautyProduct")
                        .HasForeignKey("ShoppingCartId");

                    b.Navigation("Inventory");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Inventory", b =>
                {
                    b.HasOne("BeautyStore.BeautyStoreModels.Location", "Location")
                        .WithMany("Inventory")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Item", b =>
                {
                    b.HasOne("BeautyStore.BeautyStoreModels.Order", "Orders")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyStore.BeautyStoreModels.BeautyProduct", "BeautyProducts")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyStore.BeautyStoreModels.ShoppingCart", "ShoppingCarts")
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BeautyProducts");

                    b.Navigation("Orders");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Location", b =>
                {
                    b.HasOne("BeautyStore.BeautyStoreModels.Manager", "Manager")
                        .WithMany("Location")
                        .HasForeignKey("ManagerID");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Order", b =>
                {
                    b.HasOne("BeautyStore.BeautyStoreModels.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("BeautyStore.BeautyStoreModels.Location", "Location")
                        .WithMany("Orders")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.ShoppingCart", b =>
                {
                    b.HasOne("BeautyStore.BeautyStoreModels.Customer", "Customer")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyStore.BeautyStoreModels.Location", "Location")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.BeautyProduct", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Inventory", b =>
                {
                    b.Navigation("BeautyProducts");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Location", b =>
                {
                    b.Navigation("Inventory");

                    b.Navigation("Orders");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Manager", b =>
                {
                    b.Navigation("Location");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("BeautyStore.BeautyStoreModels.ShoppingCart", b =>
                {
                    b.Navigation("BeautyProduct");

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
