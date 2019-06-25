using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Libreria.Models
{
    public class tradicional
    {
        [Required(ErrorMessage = "Por favor ingrese el Nombre del Autor del libro!")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Codigo del libro!")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Titulo del libro!")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Titulo del libro!")]
        public double precioVenta { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su Direccion para el envio!")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el peso del libro!")]
        public double peso { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Precio de Compra del libro!")]
        public double precioCompra { get; set; }
        [Required(ErrorMessage = "Por favor seleccione el Tipo de Envio!")]
        public bool? tipoEnvio { get; set; }

        // Metodos para el calculo de precios
        // Calcular el Precio de Venta
        public double GetTotal(double precioCompra, double peso, bool? envio)
        {
            double precioVenta = 0;
            double bs = 0;
            double Costoenvio = 0;

            // Calculo de flete por peso del libro
            if (peso < 1)
            {
                bs = 250;
            }
            if (peso >= 1 && peso <= 3)
            {
                bs = 500;
            }

            // Sumatoria del Precio de Venta + el Flete por Peso del Libro
            precioVenta = precioCompra + (precioCompra * 0.30)+bs;
            //precioVenta = precioVenta + bs;

            // Calculo de comision por tipo de envio
            // Envio Internacional = True
            if (envio == true)
            {
                Costoenvio = precioVenta * 0.02;
            }
            else
                Costoenvio = 0;

            // Sumatoria final del Precio de Venta Publico + el Costo del Envio.
            precioVenta = precioVenta + Costoenvio;

            return precioVenta;
        }
        // Metodos para el desenglose de los Costos Adicionales.
        public double GetPrecioVenta(double precioCompra) {
            double fleteprecioVenta = 0;
            fleteprecioVenta = precioCompra * 0.30;
            return fleteprecioVenta;
        }

        public double BsPeso(double peso) {
            double bs = 0;
            if (peso < 1)
            {
                bs = 250;
            }
            if (peso >= 1 && peso <= 3)
            {
                bs = 500;
            }
            return bs;
        }
        public double FleteEnvio(double PrecioCompra,bool? envio) {
            double precioVenta = 0;

            precioVenta = PrecioCompra + (PrecioCompra * 0.30);
            double Costoenvio = 0;
            if (envio == true)
            {
                Costoenvio = precioVenta * 0.02;
            }
            else
                Costoenvio = 0;
            return Costoenvio;
            }

 
        }


    }
