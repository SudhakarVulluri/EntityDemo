using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAnnotationsDemo.Models;

namespace DataAnnotationsDemo.Models
{
    public class DataAnnotationDbContext : DbContext
    {
        public DataAnnotationDbContext(DbContextOptions<DataAnnotationDbContext> options) : base(options) { }
        public DbSet<CustomerDetails> customerDetails { get; set; }
        public DbSet<CustomerAddressDetails> CustomerAddressDetails { get; set; }
        public DbSet<RestaurantsDetails> restaurantsDetails { get; set; }
        public DbSet<RestaurantsAddressDetails> restaurantsAddressDetails { get; set; }
        public DbSet<ProductList> ProductList { get; set; }
        public DbSet<History> History { get; set; }
        //public DbSet<TestModel> TestModel { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<RestaurantsDetails>().HasData(
        //    //    new RestaurantsDetails {RestaurantsDetailsId=7, RestaurantName="REst5",RestaurantImage="jdchy",PhoneNumber="1234",Email="S@gmail.com",Password="wdkc" }

        //    //    );
        //    modelBuilder.Entity<TestModel>().Property(x => x.Mount).HasConversion<string>();
        //    modelBuilder.Entity<TestModel>().HasData(new TestModel {Id=1,Mount=EquineBeast.Unicorn,Time=DateTime.Now });
        //    modelBuilder.Entity<TestModel3>()
        //        .HasOne(o => o.testModel4).WithOne(k=>k.testModel3)
        //            .HasForeignKey<TestModel4>(o => o.Id3);

        //    modelBuilder.Entity<TestModel4>().ToTable("TestModel3");
        //    modelBuilder.Entity<TestModel3>().ToTable("TestModel3");

        //}
    }
}
