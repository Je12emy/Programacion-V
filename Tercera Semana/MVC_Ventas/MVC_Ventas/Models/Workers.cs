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
        public int [] code { get; set; } = new int[5];
        public string [] role { get; set; } = new string [5];
        public string [] name { get; set; } = new string[5];
        public int [] salary { get; set; } = new int [5];
        public List<double> sales { get; set; }

        //Metodos para el calculo de los datos
        public double semanal(double venta)
        {
            double montoSemanal = venta * 0.23;
            return Math.Round(montoSemanal,2);
        }
        public double comision(double venta)
        {
            if (venta < 300000)
            {
                return Math.Round(venta * 0.025, 2);
            }
            if ((venta >= 300000) && (venta<450000))
            {
                return Math.Round(venta * 0.05, 2);
            }
            if ((venta >= 450000) && (venta<600000))
            {
                return Math.Round(venta * 0.075, 2);
            }
            if (venta >= 600000)
            {
                return Math.Round(venta * 0.1, 2);
            }
            else
                return venta;
        }
        public double deduccion(double salario, double comision) {
            double montoDeduccion = Math.Round((salario + comision) * 0.09);
            return montoDeduccion;
        }
        public double neto(double salario, double comision, double deduccion)
        {
            double montoNeto = Math.Round((salario + comision + deduccion),2);
            return montoNeto;
        }
    }
}