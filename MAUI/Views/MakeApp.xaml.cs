using MAUI.Models;
using Microsoft.Maui.Platform;

namespace MAUI.Views;


public partial class MakeApp : ContentPage
{
	public MakeApp()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {

        try
        {
            base.OnAppearing();       

            int appointmentId = (BindingContext as Salons).CategoryId;
            
            List<Services> salons = await App.Database6.GetServicesAsync();

            var filteredSalonsList = from s in salons
                                     where s.CategoryId.Equals(appointmentId)
                                     select s;
            Console.WriteLine(filteredSalonsList);
            listView.ItemsSource = filteredSalonsList;




        }

        catch (NullReferenceException e)
        {
            DisplayAlert("Error", e.Message, "OK");
        }
    }
    int categorieserviciu;
    async void ItemSelectat(object sender, SelectedItemChangedEventArgs e)
    {
        try
        {
            if (e.SelectedItem != null)
            {
                // Cast e.SelectedItem to the correct type
                var selectedItem = (Services)e.SelectedItem;
                // Get the CategoryId of the selected item
                 categorieserviciu = selectedItem.Id;

                Console.WriteLine(categorieserviciu);
                
            }
        }
        catch (NullReferenceException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }




    async void OnAddRezerva(object sender, EventArgs e)
    {
        //
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[8];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        var finalString = new String(stringChars);
        //
        string salonid = (BindingContext as Salons).Id;
        DateTime creata = AlegeData.Date;
        try
        {
            Appointment xlist = new Appointment();

            xlist.Id = finalString;
            Console.WriteLine(finalString);
            xlist.CreatedOn = DateTime.UtcNow;
            xlist.IsDeleted = false;
            xlist.DateTime = creata;
            xlist.UserId = "b0b3cc1b-f71e-4eaa-a8bb-6bc967f59cf5";
            xlist.SalonId = salonid;
            xlist.ServiceId = categorieserviciu;
            Console.WriteLine(categorieserviciu);
            Console.Write("SalonId");
            Console.WriteLine(salonid);
            Console.WriteLine(xlist);

            await App.Database4.SaveAppointmentAsync(xlist);
            await Navigation.PushAsync(new Appointments { BindingContext = xlist });


        }
        catch (InvalidCastException ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");

        }
    }
}