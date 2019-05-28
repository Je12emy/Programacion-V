using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Party.Models
{
    public class Guests
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool? Asistencia { get; set; } //A esta variable se le puede asignar TRUE o FALSE como cualquier Boolean pero puede tener el valor NULL
    }
}