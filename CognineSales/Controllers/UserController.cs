using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognineSales.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserPage()
        {
            return View();
        }
    }
}
