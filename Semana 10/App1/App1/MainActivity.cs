using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            EditText et = FindViewById<EditText>(Resource.Id.txt_mensaje);
            Button btn = FindViewById<Button>(Resource.Id.btn_mensaje);
            btn.Click += delegate
            {
                Toast.MakeText(this, "Hola" + et.Text, ToastLength.Long).Show();
            };
        }
    }
}

