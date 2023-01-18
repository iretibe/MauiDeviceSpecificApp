using MauiDeviceSpecificApp.UI.IViews;
using MauiDeviceSpecificApp.UI.ViewModels;

namespace MauiDeviceSpecificApp.UI.Views.Mobile;

public partial class MobileStartPage : ContentPage, IStartPage
{
	public MobileStartPage()
	{
		InitializeComponent();

        this.BindingContext = new StartPageViewModel(this.Navigation);
    }
}