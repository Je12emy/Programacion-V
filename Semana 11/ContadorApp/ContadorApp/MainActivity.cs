using Android.App;
using Android.Widget;
using Android.OS;

namespace ContadorApp
{
    [Activity(Label = "ContadorApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int contador = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            TextView et = FindViewById<TextView>(Resource.Id.Contador);
            Button btn = FindViewById<Button>(Resource.Id.btnContador);
            
            btn.Click += delegate
            {
                et.Text = "Clicks" + contador.ToString();
                contador++;
            };

        }
    }
}

