using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Libreria.Models
{
    public class digital
    {
        public string nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Codigo del libro!")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Titulo del libro!")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Titulo del libro!")]
        public double precioCompra { get; set; }
        [Required(ErrorMessage = "Por favor seleccione el Tipo de Envio!")]
        public double precioVenta { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el peso (en MB) del libro!")]
        public double tamaño { get; set; }


        // Metodos para el calculo de precios
        // Calcular el Precio de Venta
        public double GetTotal(double precioCompra, double tamaño)
        {
            double precioVenta = 0;
            double tarifaTamaño = 0;

            // Calculo de la tarifa por tamaño del archivo
            if (tamaño > 1500)
            {
                tarifaTamaño = precioCompra * 0.01;
            }
            else
            {
                tarifaTamaño = precioCompra * 0.005;
            }
            precioVenta = precioCompra + (precioCompra * 0.30) + tarifaTamaño;
            return precioVenta;
        }
        // Calculo de costos adicinales
        public double FleteTamaño(double precioCompra, double tamaño) {
            double tarifaTamaño = 0;

            // Calculo de la tarifa por tamaño del archivo
            if (tamaño > 1500)
            {
                tarifaTamaño = precioCompra * 0.01;
            }
            else
            {
                tarifaTamaño = precioCompra * 0.005;
            }
            return tarifaTamaño;
        }
        public double GetPrecioVenta(double precioCompra)
        {
            double fleteprecioVenta = 0;
            fleteprecioVenta = precioCompra * 0.30;
            return fleteprecioVenta;
        }
    }
}