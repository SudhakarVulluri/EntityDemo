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
            ClaimsIdentity identity = null;
            Roledata data = await _shopping.RoleIdentity(login);
            if(data!=null)
            {
                identity = new ClaimsIdentity(new[]
                {
                   new Claim(ClaimTypes.Name,data.Email),
                   new Claim(ClaimTypes.Role,data.RoleName)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }
            return View();
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("LoginPage");
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
                ModelState.Clear();
                return RedirectToAction("");
            }
            else
            {
                return View("RegistrationPage");
            } 
        }
    }
}
