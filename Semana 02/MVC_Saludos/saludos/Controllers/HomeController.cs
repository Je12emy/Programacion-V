using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace saludos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hora = 0;
            string saludo = "";
            hora = DateTime.Now.Hour;

            if (hora <= 12)
            {
                saludo = "Buenas Dias Clase";
            }
            else if (hora >= 18)
            {
                saludo = "Buenas Noches Clase";
            }
            else
                saludo = "Buenas Tardes Clase";
                ViewBag.Mensaje = saludo; //Llamado para este controlador.
                return View();
        }
    }
}