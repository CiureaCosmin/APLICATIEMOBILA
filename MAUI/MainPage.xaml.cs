using MAUI.Models;
using MAUI.Views;
namespace MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        async void OnRezervatClicked(object sender, EventArgs e) =>
            await Navigation.PushAsync(new ListCategoryPage
            {
                BindingContext = new Category()
            });
        
      
    }
}