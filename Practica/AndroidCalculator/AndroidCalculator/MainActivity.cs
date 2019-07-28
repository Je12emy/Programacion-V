using Android.App;
using Android.Widget;
using Android.OS;
using AndroidCalculator.Resources;
using System;
using System.Diagnostics;

namespace AndroidCalculator
{
    [Activity(Label = "AndroidCalculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Instancias de los campos de numeros
            int resultado;
            double resultadoDecimal;

            EditText text1 = FindViewById<EditText>(Resource.Id.numero1);
            EditText text2 = FindViewById<EditText>(Resource.Id.numero2);

            int numero1;
            int numero2;

            // Instancias de los botones
            Button sumar = FindViewById<Button>(Resource.Id.sumar);
            Button multiplicar = FindViewById<Button>(Resource.Id.multiplicar);
            Button dividir = FindViewById<Button>(Resource.Id.dividir);
            Button elevar = FindViewById<Button>(Resource.Id.elevar);
            Button limpiar = FindViewById<Button>(Resource.Id.limpiar);

            // Instancia de la clase para realizar operaciones
            Operaciones Operacion = new Operaciones();

            // Eventos
            sumar.Click += delegate
            {
                if (text1.Text != "" && text2.Text != "")
                {
                    numero1 = System.Convert.ToInt32(text1.Text);
                    numero2 = System.Convert.ToInt32(text2.Text);
                    System.Diagnostics.Debug.WriteLine("| Sumando:" + numero1.ToString() + " y " + numero2.ToString());
                    resultado = Operacion.Sumar(numero1, numero2);
                    Toast.MakeText(this, "El resultado es: " + resultado.ToString(), ToastLength.Long).Show();
                }
                else
                    Toast.MakeText(this, "Falta un numero!", ToastLength.Long).Show();


            };
            multiplicar.Click += delegate
            {
                if (text1.Text != "" && text2.Text != "")
                {
                    numero1 = System.Convert.ToInt32(text1.Text);
                    numero2 = System.Convert.ToInt32(text2.Text);
                    System.Diagnostics.Debug.WriteLine("| Multplicando:" + numero1.ToString() + " y " + numero2.ToString());

                    resultado = Operacion.Multiplicar(numero1, numero2);
                    Toast.MakeText(this, "El resultado es: " + resultado.ToString(), ToastLength.Long).Show();
                }
                else
                    Toast.MakeText(this, "Falta un numero!", ToastLength.Long).Show();

            };

            dividir.Click += delegate
            {
                if (text1.Text != "" && text2.Text != "")
                {
                    numero1 = System.Convert.ToInt32(text1.Text);
                    numero2 = System.Convert.ToInt32(text2.Text);
                    System.Diagnostics.Debug.WriteLine("| Divididendo:" + numero1.ToString() + " y " + numero2.ToString());

                    resultadoDecimal = Operacion.Dividir(numero1, numero2);
                    Toast.MakeText(this, "El resultado es: " + resultadoDecimal.ToString(), ToastLength.Long).Show();
                }
                else
                    Toast.MakeText(this, "Falta un numero!", ToastLength.Long).Show();
            };
            elevar.Click += delegate
            {
                if (text1.Text != "" && text2.Text != "")
                {
                    numero1 = System.Convert.ToInt32(text1.Text);
                    numero2 = System.Convert.ToInt32(text2.Text);
                    System.Diagnostics.Debug.WriteLine("| Elevando:" + numero1.ToString() + " y " + numero2.ToString());

                    resultadoDecimal = Operacion.Elevar(numero1, numero2);
                    Toast.MakeText(this, "El resultado es: " + resultadoDecimal.ToString(), ToastLength.Long).Show();
                }
                else
                    Toast.MakeText(this, "Falta un numero!", ToastLength.Long).Show();
                //Mostrar(resultadoDecimal.ToString());
            };
            limpiar.Click += delegate
            {
                text1.Text = "";
                text2.Text = "";
                Toast.MakeText(this, "Se ha limpiado la calculadora!", ToastLength.Short).Show();
            };
        }
        //static void Mostrar(string resultado) {
        //    Toast.MakeText(this,"El resultado es: " + resultado, ToastLength.Long).Show();
        //}
    }
}

