using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Modelo.Models; //Importar los modelos para usarlos en este controlador                            

namespace MVC_Modelo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Datos d = new Datos();
            d.Id = "1-111-111";
            d.Nombre = "Jeremy Zelaya";
            d.Salario = 1000000;
                   
            return View(d);
        }
    }
}