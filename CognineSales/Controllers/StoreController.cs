using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognineSales.Models;

namespace CognineSales.Controllers
{
    public class StoreController : Controller
    {
        // GET: StoreController
        private ShoppingDbContext _dbContext;
        public StoreController(ShoppingDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        // GET: SalesController
        public ActionResult StoreLoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StoreLogin(Login login)
        {
            //var loginData = _dbContext.Stores.Where(x => x.Email == login.UserEmail && x.Password == login.UserPassword).FirstOrDefault();
            //if (loginData != null)
            //{
            //    return RedirectToAction("CustomerPage");
            //}
            //else
            //{
                return View();
            //}
        }
        public ActionResult StoreRegistrationPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StoreRegistration(Stores store)
        {
            //if (store.Email != null && store.Password != null)
            //{
            //    //_dbContext.Stores.Add(store);
            //    //_dbContext.SaveChanges();
            //    return RedirectToAction("StoreLoginPage");
            //}
            //else
            //{
                return View();
            //}

        }

        // GET: StoreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreController/Create
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

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
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

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
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
