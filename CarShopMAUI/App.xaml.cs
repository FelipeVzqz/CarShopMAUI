using CarShopMAUI.Views;

namespace CarShopMAUI;

public partial class App : Application
{

	public App()
	{
		InitializeComponent();

		MainPage = new MainTabbedPage();
	}
}
