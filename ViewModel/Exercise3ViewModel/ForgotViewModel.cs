using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter8.ViewModel.Exercise3ViewModel.ForgotViewModel
{
    public class ForgotViewModel : INotifyPropertyChanged
    {
        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email=value;
                OnPropertyChanged();
            }
        }

        public ICommand ResetCommand { get;private set; }
        public event EventHandler ResetEvent;   

        public ForgotViewModel()
        {
            ResetCommand = new Command(Validation);
        }

        public void Validation()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                Toast.Make("Please Enter Your Email", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if(Email.StartsWith("@") || Email.StartsWith(".") ||
                    Email.EndsWith("@") || Email.EndsWith(".") ||
                    !Email.EndsWith("@gmail.com")
                    )
            {
                Toast.Make("Please Enter valid Email", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                ResetEvent?.Invoke(this, new EventArgs());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
