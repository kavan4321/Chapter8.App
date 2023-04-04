namespace Chapter8;
using Chapter8.View.Exercise1;
using Chapter8.View.Exercise2;
using Chapter8.View.Exercise3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new ForgotScreen());
	}
}
