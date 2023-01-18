using CommunityToolkit.Mvvm.Input;
using MauiDeviceSpecificApp.UI.IViews;
using MauiDeviceSpecificApp.UI.Services;

namespace MauiDeviceSpecificApp.UI.ViewModels
{
    public partial class StartPageViewModel
    {
        private INavigation _navigationService;

        public StartPageViewModel(INavigation navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        private async void NavivateToSecondPage()
        {
            await _navigationService.PushAsync(ViewServices.ResolvePage<ISecondPage>());
        }
    }
}
