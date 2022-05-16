
using Demos.Services.Interfaces;
using Demos.Services.MockData;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<IDataRepository, MockPastorRepository>();
            DependencyService.Register<IHttpClientRepository, HttpClientRepository>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
