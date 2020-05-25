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


        public ActionResult GenerateRandomNumbers(int count)
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>();

            for (int counter = 0; counter <= count; counter++)
            {
                numbers.Add(rnd.Next(100,1000));
            }

            return PartialView("_Numbers", numbers);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {
                if (people.PersonName.Contains("فحش"))
                {
                    ModelState.AddModelError("","استفاده از این کلمه مجاز نمی باشد");
                    return View(people);
                }

                db.People.Add(people);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(people);
        }
    }
}