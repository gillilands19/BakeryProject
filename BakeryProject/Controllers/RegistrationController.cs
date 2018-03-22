using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;

namespace BakeryProject.Controllers
{
    public class RegistrationController : Controller
    {

        BakeryEntities db = new BakeryEntities();

        public ActionResult Index()
        {
            return View(db.People.ToList());
        }

        public ActionResult Result(Message m)
        {
            return View(m);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "PersonKey, PersonLastName, PersonFirstName, PersonEmail, PersonPhone, PersonDateAdded" )]Person newPerson)
        {
            newPerson.PersonDateAdded = DateTime.Now;
            db.People.Add(newPerson);
            db.SaveChanges();

            Message registrationSuccess = new Message();
            registrationSuccess.MessageText = "Thank you for registering!";
            return RedirectToAction("Result", registrationSuccess);
        }
    }
}