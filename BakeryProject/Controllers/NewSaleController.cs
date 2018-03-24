using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;

namespace BakeryProject.Controllers
{
    public class NewSaleController : Controller
    {

        BakeryEntities db = new BakeryEntities();

        // GET: NewSale
        public ActionResult Index()
        {

            ViewBag.Products = db.Products.ToList();

            ViewBag.ProductKey = new SelectList(db.Products, "ProductKey", "ProductName");

            return View();
        }

        public ActionResult Receipt()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "SaleDetailKey, SaleKey, ProductKey, SaleDetailPriceCharged, SaleDetailQuantity, SaleDetailDiscount, SaleDetailSaleTaxPercent, SaleDetailEatInTax ")]SaleDetail newSale)
        {
            return View();
        }

    }
}