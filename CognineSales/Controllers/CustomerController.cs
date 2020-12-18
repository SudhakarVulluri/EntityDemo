using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognineSales.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace CognineSales.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        private ShoppingDbContext _dbContext;
        public CustomerController(ShoppingDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        [Route("Registration")]
        public ActionResult CustomerRegistrationPage()
        {
            return View();
        }
        public ActionResult Customers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Customers(Customer customer)
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerRegistration(Customer customer)
        {
            return View();
        }
    }
}
