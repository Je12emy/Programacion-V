using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Ventas.Models
{
    public class Workers
    {
        //Arrays con los datos de la planilla.
        //Cada arreglo es de 4 items.
        public int [] code { get; set; } = new int[4];
        public string [] role { get; set; } = new string [4];
        public string [] name { get; set; } = new string[4];
        public int [] salary { get; set; } = new int [4];

    }
}