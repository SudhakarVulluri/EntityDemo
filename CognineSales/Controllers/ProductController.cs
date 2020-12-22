using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognineSales.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace CognineSales.Controllers
{
    public class ProductController : Controller
    {
        private ShoppingDbContext DbContext;
        public ProductController(ShoppingDbContext _dbcontext)
        {
            DbContext = _dbcontext;
        }
        public ActionResult ProductList()
        {
            var data = DbContext.Products.Include("Brands").Include("Categories").Select(x=> new ProductList {ProductId=x.ProductId,ProductName=x.ProductName,ModelYear=x.ModelYear,ListPrice=x.ListPrice,CategoryName=x.Categories.CategoryName, BrandName =x.Brands.BrandName}).ToList();
            return View(data);

        }
  
        public ActionResult AddProduct()
        {
            ViewBag.Branddata = DbContext.Brands.ToList();
            ViewBag.Categorydata = DbContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Products products)
        {
           if(products!=null)
            {
                DbContext.Products.Add(products);
                DbContext.SaveChanges();
                return RedirectToAction("ProductList");
            }
            else
            {
                return View("AddProduct");
            } 
        }
        [Authorize(Roles = "User")]
        public ActionResult Details(int id)
        {
            var detailsdata = DbContext.Products.Include("Brands").Include("Categories").Where(x=>x.ProductId == id).Select(x => new ProductList { ProductId = x.ProductId, ProductName = x.ProductName, ModelYear = x.ModelYear, ListPrice = x.ListPrice, CategoryName = x.Categories.CategoryName, BrandName = x.Brands.BrandName }).FirstOrDefault();
            return View(detailsdata);
        }
        [Authorize(Roles = "Staff")]
        public ActionResult EditProduct(int Productid)
        {
            ViewBag.Branddata = DbContext.Brands.ToList();
            ViewBag.Categorydata = DbContext.Categories.ToList();
            var editdata = DbContext.Products.Include("Brands").Include("Categories").Where(x=>x.ProductId == Productid).FirstOrDefault();
            return View(editdata);
        }
        public ActionResult EditProductData(Products products)
        {
            if (products != null)
            {
                DbContext.Products.Update(products);
                DbContext.SaveChanges();
                return RedirectToAction("ProductList");
            }
            else
            {
                return View("EditProduct");
            }
        }
        public ActionResult Delete(int id)
        {
            var detailsdata = DbContext.Products.Include("Brands").Include("Categories").Where(x => x.ProductId == id).Select(x => new ProductList { ProductId = x.ProductId, ProductName = x.ProductName, ModelYear = x.ModelYear, ListPrice = x.ListPrice, CategoryName = x.Categories.CategoryName, BrandName = x.Brands.BrandName }).FirstOrDefault();
            return View(detailsdata);
        } 
        public ActionResult DeleteProduct(int id)
        {
            var data = DbContext.Products.Find(id);
            DbContext.Products.Remove(data);
            DbContext.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}
