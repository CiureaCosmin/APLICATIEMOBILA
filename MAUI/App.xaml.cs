using MAUI.Data;
using MAUI.Data.CategoryService;
using MAUI.Data.SalonsService;
using MAUI.Data.AppointmentsService;
using MAUI.Data.UsersService;
using MAUI.Data.ServicesService;
using MAUI.Views;

namespace MAUI
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public static CategoryDatabase Database2 { get; private set; }
        public static SalonsDatabase Database3 { get; private set; }
        public static AppointmentDatabase Database4 { get; private set; }
        public static UsersDatabase Database5 { get; private set; }
        public static ServicesDatabase Database6 { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            Database2 = new CategoryDatabase(new CategoryService());
            Database3 = new SalonsDatabase(new SalonsService());
            Database4 = new AppointmentDatabase(new AppointmentService());
            Database5 = new UsersDatabase(new UsersService());
            Database6 = new ServicesDatabase(new ServicesService());
            MainPage = new NavigationPage(new LoginPage());
            
        }
    }
}