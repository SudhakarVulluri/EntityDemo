using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using CognineSales.Models;
using Microsoft.AspNetCore.Authentication;
using CognineSales.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace CognineSales.Controllers
{
    public class LoginController : Controller
    {
        private ShoppingDbContext _dbContext;
        private IShopping _shopping;
        public LoginController(ShoppingDbContext dbcontext, IShopping shopping)
        {
            _dbContext = dbcontext;
            _shopping = shopping;
        }
        [AllowAnonymous]
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> LoginPage(Login login)
        {  
            Roledata data = new Roledata();
            data = await _shopping.RoleIdentity(login);
            return View();
        }
        public ActionResult RegistrationPage()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegistrationPage(Userdata userdata)
        {
            bool saving = await _shopping.SaveUser(userdata);
            if (saving)
            {
                bool saveCustomer = await _shopping.GetUserId(userdata);
            }
            return View();
        }
    }
}
