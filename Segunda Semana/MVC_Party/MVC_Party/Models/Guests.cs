using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Permite agregar validaciones al modelo

namespace MVC_Party.Models
{
    public class Guests
    {
        [Required(ErrorMessage = "Por favor ingrese su nombre.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su correo.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Por favor ingrese un correo valido.")] 
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool? Asistencia { get; set; } //A esta variable se le puede asignar TRUE o FALSE como cualquier Boolean pero puede tener el valor NULL

    }
}