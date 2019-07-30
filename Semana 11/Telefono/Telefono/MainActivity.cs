using Android.App;
using Android.Widget;
using Android.OS;

namespace Telefono
{
    [Activity(Label = "Telefono", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            EditText phoneText = FindViewById<EditText>(Resource.Id.input);
            Button btnTranslate = FindViewById<Button>(Resource.Id.translate);
            Button btnCall = FindViewById<Button>(Resource.Id.call);

            btnCall.Enabled = false;

            string translateNumber = string.Empty;

            //btnTranslate += delegate {
                
            //};
        }
    }
}

