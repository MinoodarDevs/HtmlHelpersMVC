using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MinProjectMVC.Models;

namespace MinProjectMVC.Controllers
{
    public class PeopleController : Controller
    {
        PeopleDBEntities db = new PeopleDBEntities();

        public ActionResult Index()
        {
            var people = db.People.ToList();
            return View(people);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(people);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(people);
        }
    }
}