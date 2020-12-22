using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CognineSales.Models
{
    public class ShoppingDbContext:DbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options):base(options){ }
        public DbSet<AllUsers> AllUsers { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Brands> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItems>().HasKey(x => new { x.OrderId, x.ItemId });
            modelBuilder.Entity<Stocks>().HasKey(x => new { x.StoreId, x.ProductId });

            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, CategoryName = "Fashion" },
                new Categories { CategoryId = 2, CategoryName = "Mobiles" },
                new Categories { CategoryId = 3, CategoryName = "HomeAppliances" },
                new Categories { CategoryId = 4, CategoryName = "Electronics" }
            );
            modelBuilder.Entity<Brands>().HasData(
                new Brands { BrandId = 1, BrandName = "Levis" },
                new Brands { BrandId = 2, BrandName = "Denim" },
                new Brands { BrandId = 3, BrandName = "Realme" },
                new Brands { BrandId = 4, BrandName = "Redmi" },
                new Brands { BrandId = 5, BrandName = "LG" },
                new Brands { BrandId = 6, BrandName = "Samsung" },
                new Brands { BrandId = 7, BrandName = "Asus" },
                new Brands { BrandId = 8, BrandName = "Lenovo" }
            );
            modelBuilder.Entity<Products>().HasData(
                new Products { ProductId = 1, ProductName = "LevisShirts", BrandId = 1, CategoryId = 1, ModelYear = 2020, ListPrice = 999 },
                new Products { ProductId = 2, ProductName = "LevisJeans", BrandId = 1, CategoryId = 1, ModelYear = 2020, ListPrice = 2000 },
                new Products { ProductId = 3, ProductName = "DenimJeans", BrandId = 2, CategoryId = 1, ModelYear = 2020, ListPrice = 999 },
                new Products { ProductId = 4, ProductName = "DenimShirts", BrandId = 2, CategoryId = 1, ModelYear = 2020, ListPrice = 2000 },

                new Products { ProductId = 5, ProductName = "RealmeX3", BrandId = 3, CategoryId = 2, ModelYear = 2020, ListPrice = 23000 },
                new Products { ProductId = 6, ProductName = "RealmeNarzo20", BrandId = 3, CategoryId = 2, ModelYear = 2020, ListPrice = 12000 },
                new Products { ProductId = 7, ProductName = "RedmiK20pro", BrandId = 4, CategoryId = 2, ModelYear = 2020, ListPrice = 20000 },
                new Products { ProductId = 8, ProductName = "RedmiNote10", BrandId = 4, CategoryId = 2, ModelYear = 2020, ListPrice = 2500 },

                new Products { ProductId = 9, ProductName = "AndroidTV", BrandId = 5, CategoryId = 3, ModelYear = 2020, ListPrice = 12000 },
                new Products { ProductId = 10, ProductName = "WashingMachine", BrandId = 5, CategoryId = 3, ModelYear = 2020, ListPrice = 20000 },
                new Products { ProductId = 11, ProductName = "Refridgerator", BrandId = 6, CategoryId = 3, ModelYear = 2020, ListPrice = 25000 },
                new Products { ProductId = 12, ProductName = "HomeTheater", BrandId = 6, CategoryId = 3, ModelYear = 2020, ListPrice = 14500 },

                new Products { ProductId = 13, ProductName = "Asus VivoBook14", BrandId = 7, CategoryId = 4, ModelYear = 2020, ListPrice = 35000 },
                new Products { ProductId = 14, ProductName = "Asus Tuf", BrandId = 7, CategoryId = 4, ModelYear = 2020, ListPrice = 60000 },
                new Products { ProductId = 15, ProductName = "LenovoSmartWatches", BrandId = 8, CategoryId = 4, ModelYear = 2020, ListPrice = 10000 },
                new Products { ProductId = 16, ProductName = "LenovoGamepad", BrandId = 8, CategoryId = 4, ModelYear = 2020, ListPrice = 9000 }
            );
            modelBuilder.Entity<AllUsers>().HasData(
                new AllUsers {Id = 1, Name = "DMart1", Email = "DMart1@gmail.com", Password = "DMart12", RollId = 4 },
                new AllUsers { Id = 2, Name = "DMart2", Email = "DMart2@gmail.com", Password = "DMart24", RollId = 4 },
                new AllUsers { Id = 3, Name = "DMart3", Email = "DMart3@gmail.com", Password = "DMart31", RollId = 4 },
                new AllUsers { Id = 4, Name = "DMart4", Email = "DMart4@gmail.com", Password = "DMart42", RollId = 4 },
                new AllUsers { Id = 5, Name = "Admin", Email = "Admin@Cognine.com", Password = "@dmin12", RollId = 1 },
                new AllUsers { Id = 6, Name = "Vulluri Sudhakar", Email = "sudha@Cognine.com", Password = "Sudha@12", RollId = 2 },
                new AllUsers { Id = 7, Name = "Staff 1", Email = "Staff1@Cognine.com", Password = "Staff@12", RollId = 3 },
                new AllUsers { Id = 8, Name = "Staff 2", Email = "Staff1@Cognine.com", Password = "Staff@24", RollId = 3 }
            );
            modelBuilder.Entity<Stores>().HasData(
               new Stores { StoreId = 1, Name = "DMart1", Phone = 8108108101, Street = "ABC", State = "Telangana", IsActive=true, City = "Madhapur", PinCode = 500058, Country = "India" },
               new Stores { StoreId = 2, Name = "DMart2", Phone = 9008108102, Street = "JBL", State = "Telangana", IsActive = true, City = "Madhapur", PinCode = 500059, Country = "India"},
               new Stores { StoreId = 3, Name = "DMart3", Phone = 7608108103, Street = "DEF", State = "Telangana", IsActive = true, City = "Madhapur", PinCode = 500060, Country = "India"},
               new Stores { StoreId = 4, Name = "DMart4", Phone = 98108108104, Street = "XYZ", State = "Telangana", IsActive = true, City = "Madhapur", PinCode = 500051, Country = "India"}
           );
            modelBuilder.Entity<Customer>().HasData(
               new Customer { CustomerId = 6, FirstName = "Vulluri", LastName="Sudhakar", Gender="Male",IsActive=true, Phone = 8108108101, Street = "ABC", State = "Telangana", City = "Madhapur", PinCode = 500058, Country = "India" }
           );
            modelBuilder.Entity<Staff>().HasData(
               new Staff { StaffId = 7, FirstName = "Staff", LastName="1",Gender="Male",Active=true,StoreId=1, Phone = 8108108101, Street = "ABC", State = "Telangana", City = "Madhapur", PinCode = 500058, Country = "India" },
               new Staff { StaffId = 8, FirstName = "DMart", LastName="2",Gender="Male",Active=true,StoreId=2, Phone = 9008108102, Street = "JBL", State = "Telangana", City = "Madhapur", PinCode = 500059, Country = "India" }
           );
            modelBuilder.Entity<Stocks>().HasData(
                new Stocks { StoreId = 1, ProductId = 1, Quantity = 10 },
                new Stocks { StoreId = 1, ProductId = 2, Quantity = 12 },
                new Stocks { StoreId = 1, ProductId = 3, Quantity = 15 },
                new Stocks { StoreId = 1, ProductId = 4, Quantity = 22 },

                new Stocks { StoreId = 2, ProductId = 5, Quantity = 42 },
                new Stocks { StoreId = 2, ProductId = 6, Quantity = 2 },
                new Stocks { StoreId = 2, ProductId = 7, Quantity = 8 },
                new Stocks { StoreId = 2, ProductId = 8, Quantity = 9 },

                new Stocks { StoreId = 3, ProductId = 9, Quantity = 22 },
                new Stocks { StoreId = 3, ProductId = 10, Quantity = 21 },
                new Stocks { StoreId = 3, ProductId = 11, Quantity = 32 },
                new Stocks { StoreId = 3, ProductId = 12, Quantity = 22 },

                new Stocks { StoreId = 4, ProductId = 13, Quantity = 12 },
                new Stocks { StoreId = 4, ProductId = 14, Quantity = 12 },
                new Stocks { StoreId = 4, ProductId = 15, Quantity = 16 },
                new Stocks { StoreId = 4, ProductId = 16, Quantity = 19 }
            );
            modelBuilder.Entity<Roles>().HasData(
                new Roles { Id = 1, RollName = "Admin" },
                new Roles { Id = 2, RollName = "User" },
                new Roles { Id = 3, RollName = "Staff" },
                new Roles { Id = 4, RollName = "Store" }
            );
        }
    }
}
