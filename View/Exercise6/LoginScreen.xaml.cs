using CommunityToolkit.Maui.Alerts;

namespace Chapter8.View.Exercise6;

public partial class LoginScreen : ContentPage
{
	public LoginScreen()
	{
		InitializeComponent();
	}

    private void UserNameChange()
    {
        Resources["UsernameBorder"] = Resources["UsernameBorderInvalid"];
        Resources["UsernameText"] = Resources["UsernameTextInvalid"];
    }

    private void PasswordChange()
    {
        Resources["PasswordBorder"] = Resources["PasswordBorderInvalid"];
        Resources["PasswordText"] = Resources["PasswordTextInvalid"];
    }

	private void Validation()
	{
        var userName = UserNameEntry.Text;
        var password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password))
        {
            UserNameChange();
            PasswordChange();
        }
        else if (string.IsNullOrWhiteSpace(userName) || userName != "john")
        {
            UserNameChange();
        }

        else if (string.IsNullOrWhiteSpace(password) || password.Length<4)
        {
            PasswordChange();
        }

        else
        {
            Toast.Make("Login Successful", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
    }

    private void LoginButtonClicked(object sender, EventArgs e)
    {
        Validation();
    }


    private void UserNameEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        var userName = UserNameEntry.Text;

        if (string.IsNullOrWhiteSpace(userName) || userName != "john")
        {
            UserNameChange();
        }
        else
        {
            Resources["UsernameBorder"] = Resources["UsernameBorder"];
            Resources["UsernameText"] = Resources["UsernameText"];
        }
    }


    private void PasswordEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        var password = PasswordEntry.Text;

       if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
        {
            PasswordChange();
        }
        else
        {
            Resources["PasswordBorder"] = Resources["PasswordBorder"];
            Resources["PasswordText"] = Resources["PasswordText"];
        }
    }
}