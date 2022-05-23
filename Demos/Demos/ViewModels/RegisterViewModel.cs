using Demos.Models;
using Demos.Services;
using Demos.Services.Interfaces;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demos.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        //Commands
        public AsyncCommand RegisterCommand { get; set; }
        public AsyncCommand OnAppearingCommand { get; set; }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private readonly IHttpClientRepository httpClientRepository;

        public RegisterViewModel()
        {
            httpClientRepository = DependencyService.Get<IHttpClientRepository>();
            RegisterCommand = new AsyncCommand(RegisterAsync);
            OnAppearingCommand = new AsyncCommand(OnAppearingAsync);
        }

        private async Task OnAppearingAsync()
        {
        }

        private async Task RegisterAsync()
        {
            IsBusy = true;
            try
            {
                RegisterDto credentials = new RegisterDto() { username = UserName, email = Email, password = Password};
                Response response = await httpClientRepository.RegisterAsync(credentials);
                await Shell.Current.DisplayAlert(response.Error, response.Message, "Ok");

            }
            catch (Exception)
            {

                throw;
            }
            IsBusy = false;
        }

        
    }
}
