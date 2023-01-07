
using MAUI.Models;

namespace MAUI.Views;

public partial class LoginPage : ContentPage
{
    private object listview;

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string id = UsernameEntry.Text;
        string password = PasswordEntry.Text;
        if (id == null || id == "")
        {
            await DisplayAlert("Error", "Please enter your username", "OK");
        }
        else if (password == null || password == ""|| password.Length<=4 || password.Length>=15)
        {
            await DisplayAlert("Error", "  Parola trebuie sa fie intre 5 si 15 caractere.", "OK");
        }
        else  {
            // Perform authentication logic here
            listview = App.Database5.CheckUserAsync(id);
            List<Users> users = await App.Database5.CheckUserAsync(id);
            bool usernameExists = false;
            Console.WriteLine(users);
            foreach (Users user in users)
            {
                // Check if the username exists
                usernameExists = user.UserName == id;
                if (usernameExists)
                {
                    usernameExists = true;
                    break;
                }
            }
            if (usernameExists == true)
            {
                //aici de jucam
                Sesiune sessi = new Sesiune();
                sessi.Id = 2;
                sessi.Username = id;



                // Navigate to the main page of the app
                await Navigation.PushAsync(new MainPage { BindingContext = sessi });
            }
            else
            {
                // Show an error message
                await DisplayAlert("Error", "Invalid username or password", "OK");
            }
        }
    }
        
}