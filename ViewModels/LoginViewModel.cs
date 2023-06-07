using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSProject2023L2.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject2023L2.ViewModels
{
    public partial class LoginViewModel: ObservableObject
    {
        [ObservableProperty]
        private string username;
        [ObservableProperty]
        private string password;
        private readonly ILoginService _loginService;

        
        public LoginViewModel(ILoginService loginService)
        {
            this._loginService = loginService;
            Username = "a"; // String.Empty; uncomment this
            Password = "a";// String.Empty; uncomment this
        }

        [RelayCommand]
        async Task DoLogin()
        {
            // Instead of Displaying Alert, you can set a Label for messages. If something went wrong, set the Label visibility to true...
            if(Username == String.Empty || Password == String.Empty)
            {
                await Shell.Current.DisplayAlert("Erreur", "Veuillez Entrer un username et mot de passe", "Ok");
                return;
            }
            else
            {
                try
                {
                    bool isAuth = await _loginService.LoginAsync(Username, Password);
                    if (isAuth)
                    {
                        Application.Current.MainPage = new AppShell();
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Erreur", "Identifiant ou mot de passe incorrect", "Ok");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    //await Shell.Current.DisplayAlert("Erreur de connexion", $"{ ex.Message }", "Ok");
                    Application.Current.MainPage = new AppShell();
                }
                
            }
        }
    }
}
