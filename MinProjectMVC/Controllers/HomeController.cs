using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using MinProjectMVC.Models;

namespace MinProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeopleDBEntities _db;

        public HomeController()
        {
            _db = new PeopleDBEntities();
        }

        public ActionResult Index(string personName = "", int? personId = null)
        {
            var incomes = _db.Incomes
                .Where(i => (i.People.PersonName.Contains(personName) || personName == "") && (i.People.PersonID == personId || personId==null))
                .OrderBy(i => i.People.PersonName)
                .ThenBy(i => i.IncomeAmount)
                .ToList();

            //var incomes2 = (from i in _db.Incomes
            //                where i.People.PersonName.Contains(personName) || personName == ""
            //                orderby i.People.PersonName, i.IncomeAmount
            //                select i).ToList();

            //ViewBag.PersonName = personName;

            ViewBag.PersonId = new SelectList(_db.People,"PersonID","PersonName", personId);

            return View(incomes);
        }
    }
}