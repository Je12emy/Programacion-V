using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Party_2.Models;

namespace MVC_Party_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Sign_Up() {
            return View();
        }
        [HttpPost]
        public ActionResult Sign_Up(Guests g) {
            if (ModelState.IsValid)
            {
                return View("Thank_you",g);
            }
            else
                return View();
        }
    }
}