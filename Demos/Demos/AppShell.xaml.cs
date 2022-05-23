using Demos.ViewModels;
using Demos.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Demos
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PastorInfoPage), typeof(PastorInfoPage));
            Routing.RegisterRoute(nameof(BookInfoPage), typeof(BookInfoPage));

        }

       
    }
}
