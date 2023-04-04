using Chapter8.ViewModel.Exercise3ViewModel.ForgotViewModel;

namespace Chapter8.View.Exercise3;

public partial class ForgotScreen : ContentPage
{
	private ForgotViewModel _viewModel;
	public ForgotScreen()
	{
		InitializeComponent();
		_viewModel=(ForgotViewModel)BindingContext;
        _viewModel.ResetEvent += ResetEvent;
	}

    private void ResetEvent(object sender, EventArgs e)
    {
		Navigation.PushAsync(new SetScreen());
    }
}