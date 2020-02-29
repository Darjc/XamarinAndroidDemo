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

namespace CursoAreamovil
{
    [Activity(Label = "LoginActivity", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        TextView txtTitle;
        EditText edtEmail, edtPassword;
        Button btnLogin;

        string email, password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);
            BindViews();
            email = string.Empty;
            password = string.Empty;
            // Create your application here
        }

        bool Validate(){
            return email.Equals("dar.jimenez@gmail.com") && password.Equals("123456");
        }

        private void BindViews() {

            txtTitle = FindViewById(Resource.Id.txt_title) as TextView;
            edtEmail = FindViewById(Resource.Id.edt_email_login) as EditText;
            edtPassword = FindViewById(Resource.Id.edt_password_login) as EditText;
            btnLogin = FindViewById(Resource.Id.btn_login) as Button;
           
            btnLogin.Click += BtnLogin_Click;
            edtEmail.TextChanged += EdtEmail_TextChanged;
            edtPassword.TextChanged += EdtPassword_TextChanged;
        }

        private void EdtPassword_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            password = e.Text.ToString();
        }

        private void EdtEmail_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            email = e.Text.ToString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Validate()) {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            else {
                Toast.MakeText(this, "ERROR", ToastLength.Short).Show();

            }
        }
    }
}