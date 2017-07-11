using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TED
{
    [Activity(Label = "Consul", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {

        protected override int LayoutResource
        {
            get { return Resource.Layout.main; }
        }
        int count = -4;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var texto = FindViewById<TextView>(Resource.Id.textView1);
            var menor = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var maior = FindViewById<ImageButton>(Resource.Id.imageButton2);
            menor.Click += (sender, args) =>
            {
               
                texto.Text = string.Format("{0}", count--);
            };

            maior.Click += (sender, args) =>
            {

                texto.Text = string.Format("{0}", count++);
            };
            // Get our button from the layout resource,
            // and attach an event to it
            var clickButton = FindViewById<Button>(Resource.Id.my_button);

            clickButton.Click += (sender, args) =>
              {
                  clickButton.Text = string.Format("{0} clicks!", count++);
              };

            var navigationButton = FindViewById<Button>(Resource.Id.nav_button);

            navigationButton.Click += (sender, args) =>
              {
                  var intent = new Intent(this, typeof(SecondActivity));
                  intent.PutExtra("clicks", count);
                  StartActivity(intent);
              };



            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);

        }
    }
}

