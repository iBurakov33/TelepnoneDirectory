using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelepnoneDirectory.Models;

namespace TelepnoneDirectory.Controllers
{
    public class HomeController : Controller
    {
        TelephoneContext db = new TelephoneContext();
        public ActionResult Index()
        {
            ViewBag.Telephones = db.Telephones.ToList();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Telephone telephone)
        {
            db.Telephones.Add(telephone);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}