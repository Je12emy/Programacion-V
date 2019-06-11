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
        
        // public void Cargar() {
        //    //Carga de Datos predeterminados
           

        //    //Definir los codigos de los empleados.
        //    w.code[0] = 01;
        //    w.code[1] = 02;
        //    w.code[2] = 03;
        //    w.code[3] = 04;

        //    //Definir los nombres de los empleados.
        //    w.name[0] = "Jeremy Zelaya";
        //    w.name[1] = "Susan Solano";
        //    w.name[2] = "Tamara Richards";
        //    w.name[3] = "Julian Rodriguez";

        //    //Definir los roles de los empleados.
        //    w.role[0] = "IT";
        //    w.role[1] = "Proyect Manager";
        //    w.role[2] = "Equipment Maintenance";
        //    w.role[3] = "Production Supervisor";

        //    //Definir los salarios de los empleados.
        //    w.salary[0] = 1500000;
        //    w.salary[1] = 2000000;
        //    w.salary[2] = 1200000;
        //    w.salary[3] = 1500000;

        //}

        // Workers w = new Models.Workers();

        // GET: Home
        public ActionResult Index()
        {
            // Como al inicar el programa, este metodo se iniciara para mostra la vista aca cargare los datos por primera vez.
            // Cargar();
            // Carga de Datos predeterminados.
            Workers w = new Models.Workers();

            // Definir los codigos de los empleados.
            w.code[0] = 01;
            w.code[1] = 02;
            w.code[2] = 03;
            w.code[3] = 04;

            // Definir los nombres de los empleados.
            w.name[0] = "Jeremy Zelaya";
            w.name[1] = "Susan Solano";
            w.name[2] = "Tamara Richards";
            w.name[3] = "Julian Rodriguez";

            // Definir los roles de los empleados.
            w.role[0] = "IT";
            w.role[1] = "Proyect Manager";
            w.role[2] = "Equipment Maintenance";
            w.role[3] = "Production Supervisor";

            // Definir los salarios de los empleados.
            w.salary[0] = 1500000;
            w.salary[1] = 2000000;
            w.salary[2] = 1200000;
            w.salary[3] = 1500000;

            return View(w);
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