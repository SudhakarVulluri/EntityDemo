﻿// <auto-generated />
using System;
using DataAnnotationsDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAnnotationsDemo.Migrations
{
    [DbContext(typeof(DataAnnotationDbContext))]
    [Migration("20201204095713_FIrst")]
    partial class FIrst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DataAnnotationsDemo.Models.CustomerAddressDetails", b =>
                {
                    b.Property<int>("AddressDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("NearPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressDetailsId");

                    b.HasIndex("CustomerDetailsId");

                    b.ToTable("CustomerAddressDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerDetailsId");

                    b.ToTable("customerDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductListId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsDetailsId")
                        .HasColumnType("int");

                    b.HasKey("HistoryId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.ProductList", b =>
                {
                    b.Property<int>("ProductListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("ProductListId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("ProductList");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.RestaurantsAddressDetails", b =>
                {
                    b.Property<int>("AddressDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantsDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressDetailsId");

                    b.HasIndex("RestaurantsDetailsId");

                    b.ToTable("restaurantsAddressDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.RestaurantsDetails", b =>
                {
                    b.Property<int>("RestaurantsDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantsDetailsId");

                    b.ToTable("restaurantsDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.CustomerAddressDetails", b =>
                {
                    b.HasOne("DataAnnotationsDemo.Models.CustomerDetails", "CustomerDetails")
                        .WithMany("CustomerAddressDetails")
                        .HasForeignKey("CustomerDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.ProductList", b =>
                {
                    b.HasOne("DataAnnotationsDemo.Models.RestaurantsDetails", "RestaurantsDetails")
                        .WithMany("ProductList")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("RestaurantsDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.RestaurantsAddressDetails", b =>
                {
                    b.HasOne("DataAnnotationsDemo.Models.RestaurantsDetails", "RestaurantsDetails")
                        .WithMany("RestaurantsAddressDetails")
                        .HasForeignKey("RestaurantsDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RestaurantsDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.CustomerDetails", b =>
                {
                    b.Navigation("CustomerAddressDetails");
                });

            modelBuilder.Entity("DataAnnotationsDemo.Models.RestaurantsDetails", b =>
                {
                    b.Navigation("ProductList");

                    b.Navigation("RestaurantsAddressDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
