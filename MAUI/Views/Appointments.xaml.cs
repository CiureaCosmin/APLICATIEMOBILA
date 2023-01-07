using MAUI.Models;
namespace MAUI.Views;

public partial class Appointments : ContentPage
{
    public Appointments()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        string appointmentId = (BindingContext as Appointment).Id;

        List<Appointment> salons = await App.Database4.GetAppointmentAsync();

        var filteredSalonsList = from s in salons
                                 where s.Id == appointmentId
                                 select s;
        Console.WriteLine(filteredSalonsList);
        listView.ItemsSource = filteredSalonsList;
    }

    async void BackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}