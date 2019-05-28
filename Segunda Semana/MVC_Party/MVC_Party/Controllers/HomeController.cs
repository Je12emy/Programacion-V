using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Party.Models;

namespace MVC_Party.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Reservar()
        {
            //Guests g = new Models.Guests();
            //g.Nombre = "";
            //g.Email = "";

            return View();
        }
    }
}