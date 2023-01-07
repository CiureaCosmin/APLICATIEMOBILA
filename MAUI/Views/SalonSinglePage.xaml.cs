using MAUI.Models;
using MAUI.Views;
namespace MAUI;

public partial class SalonSinglePage : ContentPage
{
    public SalonSinglePage()
    {
        InitializeComponent();
    }
    async void OnRezervat(object sender, EventArgs e) =>
           await Navigation.PushAsync(new MakeApp
           {
               BindingContext = BindingContext as Salons
           });

    async void OnItemClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }
}