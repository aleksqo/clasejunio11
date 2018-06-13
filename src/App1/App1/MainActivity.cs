using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace carpouling
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnauth;
        EditText edittextusername;
        EditText edittextpassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnauth = FindViewById<Button>(Resource.Id.button1);
            edittextusername = FindViewById<EditText>(Resource.Id.editText1);
            edittextpassword = FindViewById<EditText>(Resource.Id.editText2);
            btnauth.Click += DoAuthentication;
        }
        private void DoAuthentication(object sender, EventArgs e)
        {
            if (edittextusername.Text.Equals("bichito") && edittextpassword.Text.Equals("123456"))
            {
                Toast.MakeText(this, "Usuario valido", ToastLength.Short);
            }
            else
            {
                Toast.MakeText(this, "Usuario invalido, este telefono se destruira", ToastLength.Short).Show();

            }
        }
    }
}