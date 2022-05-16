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
    public class VersionAppViewModel : ViewModelBase
    {

        private VersionApp versionApp;
        public VersionApp VersionApp
        {
            get { return versionApp; }
            set { SetProperty(ref versionApp, value); }
        }

        public AsyncCommand OnAppearingCommand1{ get; set; }

        private readonly IHttpClientRepository httpClientVersion;

        public VersionAppViewModel()
        {
            httpClientVersion = DependencyService.Get<IHttpClientRepository>();
            OnAppearingCommand1 = new AsyncCommand(OnAppearingAsync);
        }

        private async Task OnAppearingAsync()
        {
            ApiHelper.InitializeHttpClient();
            VersionApp = await httpClientVersion.GetVersion();
            //IsBusy = true;

            ////Kunwari matagal ang api haha
            //await Task.Delay(3000);
            //Chapter = await httpClient.GetVerse();
            //IsBusy = false;
        }
    }
}
