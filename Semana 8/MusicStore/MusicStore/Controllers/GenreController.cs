using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class GenreController : Controller
    {
        // Creamos una instancia de DatosGenre
        DatosGenre _DatosGenre = new DatosGenre();


        // GET: Genre
        public ActionResult Index()
        {

            Genre genero = new Genre
            {
                // Esto es una propiedad del modelo
                Tabla = _DatosGenre.ConsultarGenero()
        };
            return View(genero);
        }
        [HttpGet]
        public ActionResult Insertar() {
            return View();
        }
        [HttpPost]
        public ActionResult Insertar(Genre _Genero)
        {
            // Si los valores que nos dan, no son Vacios ni Nulos
            if ( (!string.IsNullOrEmpty(_Genero.Nombre) ) &&  (!string.IsNullOrEmpty(_Genero.Descripcion)) )
            {
                // Llamamos al metodo de insertar.
                _DatosGenre.InsertarGenero(_Genero.Nombre, _Genero.Descripcion);
                // Redirect to Action permite llamar a otro action result, digamos a su HttpGet. Esto se ve reflejado en el enlace.
                return RedirectToAction("Index");
            }
            else
            {
                // Un ViewBag permite enviar datos del modelo hacia la Vista sin la necesidad de una modelo. 
                ViewBag.mensaje = "Debe completar la informacion";
                return View();
            }         
        }
        [HttpGet]
        public ActionResult Modificar() {
            return View();
        }
        [HttpPost]
        public ActionResult Modificar(Genre _Genero)
        {
            // Si los valores que nos dan, no son Vacios ni Nulos
            if ((!string.IsNullOrEmpty( Convert.ToString(_Genero.Nombre) )) && (!string.IsNullOrEmpty(_Genero.Nombre)) && (!string.IsNullOrEmpty(_Genero.Descripcion)))
            {
                // Llamamos al metodo de modificar.
                _DatosGenre.ModificarGenero(Convert.ToString(_Genero.Id),_Genero.Nombre, _Genero.Descripcion);
                // Redirect to Action permite llamar a otro action result, digamos a su HttpGet. Esto se ve reflejado en el enlace.
                return RedirectToAction("Index");
            }
            else
            {
                // Un ViewBag permite enviar datos del modelo hacia la Vista sin la necesidad de una modelo. 
                ViewBag.mensaje = "Debe completar la informacion";
                return View();
            }
        }


    }

}
