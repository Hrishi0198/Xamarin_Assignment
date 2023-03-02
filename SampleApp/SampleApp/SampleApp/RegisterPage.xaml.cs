using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace SampleApp
{	
	public partial class RegisterPage : ContentPage
	{	
		public RegisterPage ()
		{
			InitializeComponent ();
		}
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName.Text))
            {
                DisplayAlert("Alert", "Please enter first name", "OK");
                return;
            }
            if (string.IsNullOrEmpty(lastName.Text))
            {
                DisplayAlert("Alert", "Please enter Last name", "OK");
                return;
            }
            if (string.IsNullOrEmpty(email.Text))
            {
                DisplayAlert("Alert", "Please enter email", "OK");
                return;
            }
            if (string.IsNullOrEmpty(phone.Text))
            {
                DisplayAlert("Alert", "Please enter Phone", "OK");
                return;
            }
            var result = await DisplayAlert("Alert", "Are you sure you want to register with these details", "Yes", "No");
            if (result)
            {
                await DisplayAlert("Alert", "You registered successfully", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                return;
            }
        }



    }
}

