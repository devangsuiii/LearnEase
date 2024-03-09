using Microsoft.Maui.Controls;
using System;

namespace LearnEase
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            
            string enteredEmail = EmailEntry.Text;
            string enteredPassword = PasswordEntry.Text;

            // Define the allowed email and password
            string allowedEmail = "Xyz";
            string allowedPassword = "Xyz";

            bool isSignInSuccessful = true; 

            if (enteredEmail == allowedEmail && enteredPassword == allowedPassword)
            {
                // Navigate to the main page after successful sign-in
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                // Show an error message if sign-in fails
                await DisplayAlert("Sign-In Failed", "Invalid email or password", "OK");
            }
        }
    }
}
