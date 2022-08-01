using MetroLog.Maui;

namespace MauiMetroLogSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        LogController.InitializeNavigation(
            page => MainPage!.Navigation.PushModalAsync(page),
            () => MainPage!.Navigation.PopModalAsync());
    }
}
