using Demos.Models;
using Demos.Services.Interfaces;
using Demos.Views;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demos.ViewModels
{
    public class CarouselViewModel : ViewModelBase
    {
        //DATA ACCESS
        private readonly IDataRepository pastorRepository;

        //DATA
        public ObservableCollection<Pastor> Pastors { get; set; }
        public Pastor CurrentPastor { get; set; }

        //COMMANDS
        public AsyncCommand TappedCommand { get; set; }

        public CarouselViewModel()
        {
            Title = "Carousel";
            pastorRepository = DependencyService.Get<IDataRepository>();
            Pastors = pastorRepository.GetPastors();

            TappedCommand = new AsyncCommand(TappedAsync);
        }

        private async Task TappedAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(PastorInfoPage)}?PastorId={CurrentPastor.Id}");
        }
    }
}
