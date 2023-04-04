namespace Chapter8.View.Exercise3;

public partial class SetScreen : ContentPage
{
	public SetScreen()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ChangeScreen());
    }
}