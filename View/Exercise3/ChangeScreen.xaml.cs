using Chapter8.ViewModel.Exercise3ViewModel.ChangeViewModel;

namespace Chapter8.View.Exercise3;

public partial class ChangeScreen : ContentPage
{
	private ChangeViewModel _viewModel;
	public ChangeScreen()
	{
		InitializeComponent();
		_viewModel=(ChangeViewModel)BindingContext;
        _viewModel.SaveEvent += SaveEvent;
	}

    private void SaveEvent(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ConfirmScreen());
    }
}