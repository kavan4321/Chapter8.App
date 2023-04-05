
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter8.ViewModel.Exercise3ViewModel.ChangeViewModel
{
    public class ChangeViewModel:INotifyPropertyChanged
    {
        private string _password;
        private string _confirmPassword;

        public string Password
        {
            get => _password;
            set
            {
                _password=value;
                OnPropertyChanged();
            }
        }
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword=value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; private set; }
        public event EventHandler SaveEvent;

        public ChangeViewModel()
        {
            SaveCommand = new Command(Validation);
        }

        public void Validation()
        {
            if(string.IsNullOrWhiteSpace(Password) && 
               string.IsNullOrWhiteSpace(ConfirmPassword)
                ) 
            {
                Toast.Make("Please enter values",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                Toast.Make("Please enter password", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                Toast.Make("Please enter confirm passwor", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if(Password.Length <6 || ConfirmPassword.Length<6 ) 
            {
                Toast.Make("password length is small", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (!Password.Equals(ConfirmPassword))
            {
                Toast.Make("Password & confirm password did't match", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                SaveEvent?.Invoke(this,new EventArgs());
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
