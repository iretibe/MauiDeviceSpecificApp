using MauiDeviceSpecificApp.UI.IViews;
using MauiDeviceSpecificApp.UI.ViewModels;

namespace MauiDeviceSpecificApp.UI.Views.Desktop;

public partial class DesktopStartPage : ContentPage, IStartPage
{
	public DesktopStartPage()
	{
		InitializeComponent();

		this.BindingContext = new StartPageViewModel(this.Navigation);
	}
}