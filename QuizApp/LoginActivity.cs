using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using QuizApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp
{
    [Activity(Label = "Login", Theme = "@style/AppTheme")]
    public class LoginActivity : AppCompatActivity
    {
        Button b1;
        EditText et1, et2;
        TextView tv1;
        DataLayer layer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_page);
            layer = new DataLayer();
            et1 = FindViewById<EditText>(Resource.Id.text1);
            et2 = FindViewById<EditText>(Resource.Id.text2);

            b1 = FindViewById<Button>(Resource.Id.b1);
            tv1 = FindViewById<TextView>(Resource.Id.text3);
            b1.Click += B1_Click;
            tv1.Click += Tv1_Click;
        }

        private void Tv1_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
            Finish();
        }

        private void B1_Click(object sender, System.EventArgs e)
        {
            string username = et1.Text.Trim();
            string password = et2.Text;
            if (username.Length == 0 || password.Length == 0)
            {
                Toast.MakeText(this, "Please Fill All Boxes", ToastLength.Long).Show();
            }
            else
            {
                if (username.Equals("admin") && password.Equals("admin@12345"))
                {
                    Intent intent = new Intent(this, typeof(AdminActivity));
                    StartActivity(intent);
                    Finish();
                }
                else if (layer.ValidUser(username, password))
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    Finish();
                }
                else
                {
                    Toast.MakeText(this, "Invalid Profile Name and Password", ToastLength.Long).Show();
                }
            }

        }

    }
}