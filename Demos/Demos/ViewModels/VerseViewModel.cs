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
    public class VerseViewModel : ViewModelBase
    {

        private Chapter chapter;
        public Chapter Chapter
        {
            get { return chapter; }
            set { SetProperty(ref chapter, value); }
        }

        public AsyncCommand OnAppearingCommand { get; set; }

        private readonly IHttpClientRepository httpClient;

        public VerseViewModel()
        {
            httpClient = DependencyService.Get<IHttpClientRepository>();
            OnAppearingCommand = new AsyncCommand(OnAppearingAsync);
        }

        private async Task OnAppearingAsync()
        {
          
            IsBusy = true;

            //Kunwari matagal ang api haha
            await Task.Delay(3000);
            Chapter = await httpClient.GetVerse();
            IsBusy = false;
        }
    }
}
