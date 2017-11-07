using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Flooringsite.DAL;
using Flooringsite.Models;


namespace Flooringsite.Controllers
{
    public class HomeController : Controller
    {
        private DB db = new DB();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult CommercialResidential()
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Schedule()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Schedule([Bind(Include = "Customer_Id,FirstName,LastName,CustomerEmail,ContactNumber,RequestedDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }
    }
}