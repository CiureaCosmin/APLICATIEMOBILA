using MAUI.Models;
namespace MAUI.Views;

public partial class SalonsPage : ContentPage
{
    public SalonsPage()
    {
        InitializeComponent();
    }
    
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        int categoryId = (BindingContext as Category).Id;
        //listView.ItemsSource = await App.Database3.GetSalonsAsync(0);
        List<Salons> salons = await App.Database3.CheckSalonAsync("user@user.com");
       
        var filteredSalonsList = from s in salons
                                 where s.CategoryId==categoryId
                                 select s;
        Console.WriteLine(filteredSalonsList);
        listView.ItemsSource = filteredSalonsList;
    }
    
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new SalonSinglePage
            {
                BindingContext = e.SelectedItem as Salons
            });
        }

    }
    async void OnItemClicked(object sender, EventArgs e)
    {



        await Navigation.PushAsync(new MainPage());


    }
}