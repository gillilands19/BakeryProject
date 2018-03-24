using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;

namespace BakeryProject.Controllers
{
    public class HomeController : Controller
    {
        BakeryEntities db = new BakeryEntities();
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is My Bakery 172 Project";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Don't Contact us! We're not even a real Bakery!";

            return View();
        }
    }
}