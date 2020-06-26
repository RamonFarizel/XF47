using System;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace XF47
{
    public class MainPageViewModel : BaseViewModel
    {
        Login _usuario = new Login();
        public Login Usuario
        {
            get => _usuario;
            set => SetProperty(ref _usuario,value);
        }

        ICommand _loginCommand;
        public ICommand LoginCommand => _loginCommand ?? (_loginCommand = new Command(ExecuteLoginCommand));

        public MainPageViewModel()
        {

        }

        private void ExecuteLoginCommand()
        {
            Application.Current.MainPage.DisplayAlert("Testando", "Teste", "Ok");
        }
    }

    public class Login : BindableObject
    {
        string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
}
