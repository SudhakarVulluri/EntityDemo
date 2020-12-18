using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognineSales.Models;

namespace CognineSales.Controllers
{
    public class StaffController : Controller
    {
        // GET: StaffController
        private ShoppingDbContext _dbContext;
        public StaffController(ShoppingDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public ActionResult StaffLoginPage()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult StaffLogin(Login login)
        //{
        //    var loginData = _dbContext.Staff.Where(x => x.Email == login.UserEmail && x.Password == login.UserPassword).FirstOrDefault();
        //    if (loginData != null)
        //    {
        //        return RedirectToAction("CustomerPage");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        public ActionResult StaffRegistrationPage()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult StaffRegistration(Staff staffdata)
        //{
        //    if (staffdata.Email != null && staffdata.Password != null)
        //    {
        //        //_dbContext.Staff.Add(staffdata);
        //        //_dbContext.SaveChanges();
        //        return RedirectToAction("StaffLoginPage");
        //    }
        //    else
        //    {
        //        return View();
        //    }

        //}

        // GET: StaffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaffController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
