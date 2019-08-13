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
using App1.WebReference;

namespace App1
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            Button btn = FindViewById<Button>(Resource.Id.button1);
            TextView tv1 = FindViewById<TextView>(Resource.Id.textView1);
            TextView tv2 = FindViewById<TextView>(Resource.Id.textView2);
            btn.Click += delegate{
                WebReference.WebService1 cliente = new WebService1();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds = cliente.Consulta_General();
                tv1.Text = ds.Tables[0].Rows[0][1].ToString();
                tv1.Text = ds.Tables[0].Rows[0][2].ToString();
            };
        }
    }
}