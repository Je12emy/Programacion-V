using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Libreria.Models;

namespace Libreria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Pantalla inicial del programa
        public ActionResult Index()
        {
            return View();
        }
        // Pantalla para seleccionar el tipo de libro.
        public ActionResult libro() {
            return View();
        }
        // Form para capturar los datos de los libros de tipo Tradicional
        [HttpGet]
        public ActionResult tradicional() {
            return View();
        }
        [HttpPost]
        public ActionResult tradicional(tradicional t) {
            if (ModelState.IsValid)
            {
                return View("Tradicional_Factura",t);
            }
            else
                return View();
        }
        // Form para capturar los datos de los libros de tipo Digital
        [HttpGet]
        public ActionResult digital() {
            return View();
        }
        [HttpPost]
        public ActionResult digital(digital d) {
            if (ModelState.IsValid)
            {
                return View("Digital_Factura",d);
            }
            else
            {
                return View();
            }
        }
    }
}