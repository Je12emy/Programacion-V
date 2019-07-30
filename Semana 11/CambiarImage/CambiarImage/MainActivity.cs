using Android.App;
using Android.Widget;
using Android.OS;

namespace CambiarImage
{
    [Activity(Label = "CambiarImage", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int bandera = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button btn = FindViewById<Button>(Resource.Id.btnCambiar);
            ImageView img = FindViewById<ImageView>(Resource.Id.imagen1);
            btn.Click += delegate {
                if (bandera == 0)
                {
                    img.SetImageResource(Resource.Drawable.off);
                    bandera = 1;
                    Toast.MakeText(this,"Apagando",ToastLength.Short).Show();
                }
                else if (bandera == 1)
                {
                    img.SetImageResource(Resource.Drawable.on);
                    bandera = 0;
                    Toast.MakeText(this, "Encendiendo", ToastLength.Short).Show();
                }
            };
        }
    }
}

