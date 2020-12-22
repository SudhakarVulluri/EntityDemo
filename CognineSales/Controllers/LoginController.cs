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
using Microsoft.AspNetCore.Identity;

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
        public IActionResult LoginPage()
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
                   new Claim(ClaimTypes.Role,data.RoleName),
                   new Claim(ClaimTypes.Email,data.Name),
                   new Claim(ClaimTypes.MobilePhone,Convert.ToString(data.Id))
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                var user = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, user);
                return RedirectToAction("UserPage", "User");
            }
            else
            {
                ViewBag.Error = "Email or password is incorrect";
                return View();
            }
            
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("LoginPage");
        }
        public ActionResult RegistrationPage()
        {
            ViewBag.ManagerList = _dbContext.Staff.Where(x => x.ManagerId == null && x.StoreId == Convert.ToInt32(User.Claims.ElementAt(3).Value)).Include("AllUsers").Select(x => new { x.StaffId, x.AllUsers.Name }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegistrationPage(Userdata userdata)
        {
            bool saving = await _shopping.SaveUser(userdata);
            if (saving)
            {
                await _shopping.SaveData(userdata);
                ModelState.Clear();
                return RedirectToAction("LoginPage");
            }
            else
            {
                return View("RegistrationPage");
            } 
        }
    }
}
