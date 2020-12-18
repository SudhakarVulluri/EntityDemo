using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CognineSales.Models;
using Microsoft.EntityFrameworkCore;

namespace CognineSales.Views.ViewComponents
{
    public class ProductByCategory : ViewComponent
    {
        private ShoppingDbContext _dbContext;
        public ProductByCategory(ShoppingDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var items = await GetItemsAsync(categoryId);
            return View(items);
        }
        private Task<List<Products>> GetItemsAsync(int categoryId)
        {
            ViewBag.CategoryName = _dbContext.Categories.Where(x => x.CategoryId == categoryId).Select(y => y.CategoryName).FirstOrDefault();
            //var data = from Cate in _dbContext.categories
            //           join prod in _dbContext.products on Cate.CategoryId equals prod.CategoryId into grp
            //           from bran in _dbContext.brands

            //           select new ProductList
            //           {
            //                ProductId=prod.ProductId,
            //                ProductName=prod.ProductName,

            //           }.ToList();
            return _dbContext.Products.Where(x=>x.CategoryId == categoryId).ToListAsync();
        }
    }
}
