using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidCalculator.Resources
{
    public class Operaciones
    {
        public int Sumar(int a, int b) {
            return a + b;
        }
        public int Multiplicar(int a,int b) {
            return a * b;
        }
        public double Dividir(int a,int b) {
            return Convert.ToDouble(a/b);
        }
        public double Elevar(int a,int b) {
            return Math.Pow(a,b);
        }

    }
}