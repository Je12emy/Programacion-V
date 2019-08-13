using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        // Puedo tener a Intent a como variable global y cuando lo referencie en un nuevo boton, le doy un nuevo intent.
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button btn = FindViewById<Button>(Resource.Id.button1);

            btn.Click += delegate
            {
                Intent a = new Intent(this, typeof(Activity1));
                // Cambia la actividad y nos envia a la actividad que pedimos con el typeof
                StartActivity(a);
            };
        }
    }
}

