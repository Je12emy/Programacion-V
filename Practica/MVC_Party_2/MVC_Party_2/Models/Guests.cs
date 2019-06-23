using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Agregar las propiedades de validacion

namespace MVC_Party_2.Models
{
    public class Guests
    {
        [Required(ErrorMessage = "Please type your your name!")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please type your phone number!")]
        public string phone { get; set; }
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Invalid email characters detected!")]
        public string mail { get; set; }
        public bool? assistance { get; set; }

    }
}