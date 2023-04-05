namespace Chapter8.View.Exercise3;

public partial class ConfirmScreen : ContentPage
{
	public ConfirmScreen()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }
}