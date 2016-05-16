using grsu.dunec.project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;

namespace grsu.dunec.project.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            var books = db.Books.ToList();
            return View(books);
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
             return View(id);
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.person + ", за покупку!";
        }
    }
}