using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Ventas.Models
{
    public class Workers
    {
        //Arrays con los datos de la planilla.
        public int [] code { get; set; }
        public string [] role { get; set; }
        public string [] name { get; set; }
        public int [] salary { get; set; }

    }
}