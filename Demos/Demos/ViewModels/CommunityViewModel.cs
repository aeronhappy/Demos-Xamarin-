using Demos.Models;
using Demos.Services;
using Demos.Services.Interfaces;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demos.ViewModels
{
    internal class CommunityViewModel : ViewModelBase
    {

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 3;
        //Collections
        private ObservableCollection<Community> communities;
        public ObservableCollection<Community> Communities
        {
            get { return communities; }
            set { SetProperty(ref communities, value); }
        }


        //Single Data
        public Page<Community> PagedCommunity { get; set; }

        //Data access
        private readonly IHttpClientRepository client;

        //Commands
        public AsyncCommand OnAppearingCommand { get; set; }
        public AsyncCommand RemainingThresholdReachCommand { get; set; }

        public CommunityViewModel()
        {
            OnAppearingCommand = new AsyncCommand(OnAppearingAsync);
            RemainingThresholdReachCommand = new AsyncCommand(RemainingThresholdReachAsync);
            client = DependencyService.Get<IHttpClientRepository>();
        }

        private async Task RemainingThresholdReachAsync()
        {
            IsBusy = true;
            await Task.Delay(5000);
            if (PagedCommunity.NextPage != null)
            {
                PageNumber++;
                PagedCommunity = await client.GetCommunity(PageNumber, PageSize);
                foreach (Community item in PagedCommunity.Data)
                {
                    Communities.Add(item);
                }
            }
            IsBusy = false;
        }

        private async Task OnAppearingAsync()
        {
            
            PagedCommunity = await client.GetCommunity(PageNumber, PageSize);
            Communities = PagedCommunity.Data;
        }
    }
}
