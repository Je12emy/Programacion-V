using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Salarios.Models
{
    public class Datos
    {

        // Cantidad de ventas 
        [Required(ErrorMessage = "Ingresar Monto de Ventas para Jorge Soto")]
        public double Ventas11 { get; set; }

         [Required(ErrorMessage = "Ingresar Monto de Ventas para Ana Mendez")]
        public double Ventas12 { get; set; }

         [Required(ErrorMessage = "Ingresar Monto de Ventas para Oscar Segura")]
         public double Ventas13 { get; set; }

         [Required(ErrorMessage = "Ingresar Monto de Ventas para David Hurtado")]
         public double Ventas14 { get; set; }

         [Required(ErrorMessage = "Ingresar Monto de Ventas para Susana Araya")]
         public double Ventas15 { get; set; }

         public double Ventas21 = 0;


        // Salario Bases
        public double Base11 = 80000;
        public double Base12 = 87000;
        public double Base13 = 84000;
        public double Base14 = 85000;
        public double Base15 = 73000;
        public double Base21 = 187000;

        // Calcula salario Semanal
        // Estos metodos pueden ser invocados desde cualquier parte del codigo en HTML.
        public double Semanal(double value)
        {
            double semanal = (value * 0.2307692307692308);
            return Math.Round(semanal, 2);
        }

        // Calcula las deducciones
        public double Deducciones(double salario, double comision)
        {
            double deducciones = ((salario + comision)*0.09);
            return Math.Round(deducciones, 2);
        }

        //Calcula el salario neto
        public double Neto(double salario, double comision, double deducciones)
        {
            double neto = (salario + comision - deducciones);
            return Math.Round(neto, 2);
        }

        // Calcula las comisiones
        public double Comisiones(double value)
        {
            if (value < 30000)
                return Math.Round((value * 0.025), 2);
            else if ((value >= 30000) && (value < 45000))
                return Math.Round((value * 0.05), 2);
            else if ((value >= 45000) && (value < 60000))
                return Math.Round((value * 0.075), 2);
            else if (value >= 60000)
                return Math.Round((value * 0.1), 2);
            else
                return value;
        }
    }
}