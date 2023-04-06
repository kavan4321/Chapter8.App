namespace Chapter8;
using Chapter8.View.Exercise1;
using Chapter8.View.Exercise2;
using Chapter8.View.Exercise3;
using Chapter8.View.Exercise4;
using Chapter8.View.Exercise5;
using Chapter8.View.Exercise6;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginScreen())
		{ BarBackgroundColor = Colors.DarkCyan };
	}
}
