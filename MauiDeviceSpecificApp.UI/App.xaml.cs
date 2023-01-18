using MauiDeviceSpecificApp.UI.IViews;
using MauiDeviceSpecificApp.UI.Services;

namespace MauiDeviceSpecificApp.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(ViewServices.ResolvePage<IStartPage>());
        }
    }
}