using MAUI.Models;

namespace MAUI.Views;

public partial class ListCategoryPage : ContentPage
{
    public ListCategoryPage()
    {
        try
        {
            InitializeComponent();
        }
        catch (NullReferenceException e)
        {
            DisplayAlert("Error", e.Message, "OK");
        }
    }

    protected override async void OnAppearing()
    {

        try
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database2.GetCategoryAsync();
        }

        catch (NullReferenceException e)
        {
            DisplayAlert("Error", e.Message, "OK");
        }
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        try
        {
            if (e.SelectedItem != null)
            {

                await Navigation.PushAsync(new SalonsPage
                {
                    BindingContext = e.SelectedItem as Category
                });
            }
        }
        catch (NullReferenceException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
    async void OnItemClicked(object sender, EventArgs e)
    {
        
       

            await Navigation.PopAsync();
        

    }
}