﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;

namespace BakeryProject.Controllers
{
    public class ProductsController : Controller
    {
        BakeryEntities db = new BakeryEntities();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}