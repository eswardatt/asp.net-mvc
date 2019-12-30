using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using basics.Models;

namespace basics.Controllers
{
    public class HomeController : Controller
    {
        DbConnection db = new DbConnection();
        public ActionResult Index()
        {
            //ViewBag.Countries = new List<string>
            //{
            //    "India",
            //    "USA",
            //    "UK",
            //    "Australia",
            //    "Japan"
            //};
            ViewData["Countries"] = new List<string>
            {
                "India",
                "USA",
                "UK",
                "Australia",
                "Japan"
            };
            return View();
        }
        public ActionResult Get()
        {
            List<Emplpoyee> emplpoyees = db.Emplpoyees.ToList();
            return View(emplpoyees);
        }
        public ActionResult Edit(int Id)
        {
            Emplpoyee emplpoyee = db.Emplpoyees.Single(x => x.ID == Id);
            return View(emplpoyee);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}