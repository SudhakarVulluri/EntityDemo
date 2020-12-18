using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAnnotationsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAnnotationsDemo.Controllers
{
    public class Demo : Controller
    {
        private DataAnnotationDbContext _DbContext;
        public Demo(DataAnnotationDbContext Dbcontext)
        {
            _DbContext = Dbcontext;
        }
        
        public IActionResult Index()
        {
            //List<Cognine> Cogninibase = new List<Cognine>();
            //var cust = from COgninebase in _DbContext.CognineBase
            //            join custom in _DbContext.CustomerDetails on COgninebase.CustomerDetails.CustomerDetailsId equals custom.CustomerDetailsId
            //            select new Cognine
            //            {
            //                CustomerName = custom.LastName
            //           };
            //TestModel2 model = new TestModel2(1);
            //ViewBag.Value = model.Value;
            //ViewBag.data = model.GetHashCode();
            //TestModel2 model2 = model;
            //model2.Value = 2;
            //bool data = ReferenceEquals(model, model2);
            return View(_DbContext.customerDetails.ToList());
        }
    }
}
