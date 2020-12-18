using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CognineSales.Controllers
{
    public class Account : Controller
    {
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return RedirectToAction("LoginPage", "Login");
        }
    }
}
