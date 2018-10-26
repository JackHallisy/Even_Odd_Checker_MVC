using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvenOddCheckerMVC.Controllers
{
    public class NumCheckerController : Controller
    {
        // GET: NumChecker
        public ActionResult Index()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);

            ViewBag.randomNumber = randomNumber;

            return View();
        }

    }
}