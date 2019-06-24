using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interest_rates.Models;

namespace Interest_rates.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Calculate() {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(Interest i) {
            if (ModelState.IsValid)
                return View("Result",i);
            else
                return View();
        }
    }
}