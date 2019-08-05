using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Ventas.Models;

namespace MVC_Ventas.Controllers
{
    public class HomeController : Controller
    {



        // GET: Home

        // Vista para entrar a la plataforma.
        public ActionResult Index()
        {
            return View();
        }

        // Pagina para la vista de la tabla.
        [HttpGet]
        public ActionResult tabla()
        {
            // Carga de Datos predeterminados.
            Workers w = new Models.Workers();

            // Definir los codigos de los empleados.
            w.code[0] = 01;
            w.code[1] = 02;
            w.code[2] = 03;
            w.code[3] = 04;
            w.code[4] = 05;

            // Definir los nombres de los empleados.
            w.name[0] = "Jeremy Zelaya";
            w.name[1] = "Susan Solano";
            w.name[2] = "Tamara Richards";
            w.name[3] = "Julian Rodriguez";
            w.name[4] = "Angeles Rostran";

            // Definir los roles de los empleados.
            w.role[0] = "IT";
            w.role[1] = "Proyect Manager";
            w.role[2] = "Equipment Maintenance";
            w.role[3] = "Production Supervisor";
            w.role[4] = "Accountant";

            // Definir los salarios de los empleados.
            w.salary[0] = 1500000;
            w.salary[1] = 2000000;
            w.salary[2] = 1200000;
            w.salary[3] = 1500000;
            w.salary[4] = 1750000;
            return View(w);
        }
        [HttpPost]
        public ActionResult tabla(Workers w) {
            if (ModelState.IsValid)
            {
                // Retorna el View 'Datos' con la instancia del modelo de 'Workers'.
                return View("Datos",w);
            }
            else           
                // Retorna al View de Tabla.
                return View();
        }

        public ActionResult Configuracion(Workers w)    //Recibir una instancia de Workers como parametro y pasarlo al view.
        {
            //Averiguar como pasar los datos cargados desde Index a esta clase.
            //Workers w = new Models.Workers();
            //w.code[0] = 01;
            //w.code[1] = 02;
            //w.code[2] = 03;
            //w.code[3] = 04;
            //w.code[0] = 01;

            return View(w);
        }       
    }
}