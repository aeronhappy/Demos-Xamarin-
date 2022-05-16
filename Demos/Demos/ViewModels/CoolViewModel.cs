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
    public class CoolViewModel : ViewModelBase
    {

        private Cool cool;
        public Cool Cool
        {
            get { return cool; }
            set { SetProperty(ref cool, value); }
        }

        public AsyncCommand OnAppearingCommand1 { get; set; }

        private readonly IHttpClientRepository httpClientVersion;

        public CoolViewModel()
        {
            httpClientVersion = DependencyService.Get<IHttpClientRepository>();
            OnAppearingCommand1 = new AsyncCommand(OnAppearingAsync);
        }

        private async Task OnAppearingAsync()
        {
            ApiHelper.InitializeHttpClient();
            Cool = await httpClientVersion.GetCool();
        }
    }
}
