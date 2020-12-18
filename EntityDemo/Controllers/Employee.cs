using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDemo.Models;

namespace EntityDemo.Controllers
{    
    public class Employee : Controller
    {
        private readonly EmployeeDbContext _DbContext;
        public Employee(EmployeeDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmployeeDetails Details)
        {
            return View();
        }
    }
}
