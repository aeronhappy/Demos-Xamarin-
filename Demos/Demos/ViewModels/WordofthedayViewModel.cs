using Demos.Models;
using Demos.Services;
using Demos.Services.Interfaces;
using Demos.Views;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demos.ViewModels
{
    public class WordofthedayViewModel : ViewModelBase
    {
        private WordOfTheDay wordOfTheDay;
        public WordOfTheDay WordOfTheDay
        {
            get { return wordOfTheDay; }
            set { SetProperty(ref wordOfTheDay, value); }
        }

        private readonly IWordofthedayRepository wordofthedayRepo;
        public AsyncCommand OnAppearingCommand { get; set; }

        public WordofthedayViewModel()
        {

            //Data access initialization
            wordofthedayRepo = DependencyService.Get<IWordofthedayRepository>();
            OnAppearingCommand = new AsyncCommand(OnAppearingAsync);
            ApiHelper.InitializeAzureClient(null);
        }

        private async Task OnAppearingAsync()
        {
            WordOfTheDay = await wordofthedayRepo.GetWordoftheday();
        }
    }
}
