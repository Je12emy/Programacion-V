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
        [HttpGet] //Se usa para visualizar la forma
        //La primera vez que se carga, se hace el GET
        public ActionResult Reservar()
        {
            //Guests g = new Models.Guests();
            //g.Nombre = "";
            //g.Email = "";

            return View();
        }
        //Controlador para la reserva
        [HttpPost] //Capturar los datos de la forma y enviarlos
        //Al hacer un submit, se da el POST y se ejecuta la clase
        public ViewResult Reservar(Guests gr) {
            if (ModelState.IsValid) //ModelState.IsValid, se va a modelo de Datos y ahi hace las validaciones correspondientes.
            {
                return View("Gracias", gr);
            }
            else
            {
                return View();
            }
        }

    }
}