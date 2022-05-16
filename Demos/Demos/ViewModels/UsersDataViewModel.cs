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
    public class UsersDataViewModel : ViewModelBase
    {
        //Comands
        public AsyncCommand AppearingCommand { get; set; }
        //Data access
        private readonly IHttpClientRepository clientRepository;

        private Accounts accounts;
        public Accounts Accounts
        {
            get { return accounts; }
            set { SetProperty(ref accounts, value); }
        }


        public UsersDataViewModel()
        {
            clientRepository = DependencyService.Get<IHttpClientRepository>();
            AppearingCommand = new AsyncCommand(OnAppearingAsync);
        }

        private async Task OnAppearingAsync()
        {
            //Itong pag initialize kuya aeron pag bukas na pagbukas ng app dapat nilalagay hehe nilagay kolang dito
            ApiHelper.InitializeClient();
            try
            {
                Accounts = await clientRepository.GetAccountsAsync();
            }
            catch (OperationCanceledException)
            {
                await Shell.Current.DisplayAlert("Error", "Can't connect to the server", "Ok");
            }
            catch (Exception)
            { 
                //TODO: Resolve this
            }
        }
    }
}
