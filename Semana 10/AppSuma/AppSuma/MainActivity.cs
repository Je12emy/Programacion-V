using Android.App;
using Android.Widget;
using Android.OS;

namespace AppSuma
{
    [Activity(Label = "AppSuma", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Instancias de los componentes
            EditText texto1 = FindViewById<EditText>(Resource.Id.txtNumero1);
            EditText texto2 = FindViewById<EditText>(Resource.Id.txtNumero2);
            Button btn = FindViewById<Button>(Resource.Id.btnSumar);        

            // Programar el evento del boton
            btn.Click += delegate
            {
                // Capturar los numeros en nuevas variables

                int resultado;
                int numero1 = System.Convert.ToInt32(texto1.Text);
                int numero2 = System.Convert.ToInt32(texto2.Text);
                resultado = numero1 + numero2;
                Toast.MakeText(this, "El resultado es:" + resultado, ToastLength.Long).Show();
            };
        }
    }
}

