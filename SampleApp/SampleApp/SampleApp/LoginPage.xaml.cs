using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            bool isValid = ValidateUserCredentials(username, password);

            if (isValid)
            {

                Navigation.PushAsync(new MainPage());
            }
            else
            {

                DisplayAlert("Login failed", "Invalid username or password", "OK");
            }
        }

        private bool ValidateUserCredentials(string username, string password)
        {

            return username == "User1" && password == "userpassword";
        }

        void OnRegisterButtonClicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        
        


    }


}


