using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Salarios.Models;

namespace Salarios.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Ese controlador nos envia a un View en donde tendremos una interfaz 
            // para entrar a las otras partes del programa.
            return View();
        }

        [HttpGet]
        // La primera vez que se carga se da el GET y con el boton para 
        // enviar los datos de ventas obtenemos el POST.
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        // El POST al cual accedemos con el boton, nos envia a este metodo del controlador.
        // Ademas recibe a la variable de tipo Datos la cual es de tipo Datps (Modelo).
        public ActionResult Ingresar(Datos Datos)
        {
            if (ModelState.IsValid)
            {
                // Si el modelo es valido, nos direcciona al View llamado: 'Ver' y le da el modelo como parametro.
                return View("Ver", Datos);
                //return View([Nombre de la Vista], [Modelo]).
            }
            else
                return View();
        }

    }
}