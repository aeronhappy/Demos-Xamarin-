using Demos.Models;
using Demos.Services.Interfaces;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Demos.ViewModels
{
    public class SearchingViewModel : ViewModelBase
    {
        //Commands
        public MvvmHelpers.Commands.Command OnAppearingCommand { get; set; }
        public MvvmHelpers.Commands.Command TextChangedCommand { get; set; }

        //Data
        private ObservableCollection<Music> musics;
        public ObservableCollection<Music> Musics
        {
            get { return musics; }
            set { SetProperty(ref musics, value); }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set { SetProperty(ref searchText, value); }
        }


        //Data Access
        private readonly IDataRepository dataRepository;

        public SearchingViewModel()
        {
            dataRepository = DependencyService.Get<IDataRepository>();

            OnAppearingCommand = new MvvmHelpers.Commands.Command(Appearing);
            TextChangedCommand = new MvvmHelpers.Commands.Command(SearchTextChanged);
            Musics = new ObservableCollection<Music>();
        }

        private void SearchTextChanged(object obj)
        {
            Musics = dataRepository.GetFilteredMusic(SearchText);
        }

        private void Appearing(object obj)
        {
            Musics = dataRepository.GetMusics();
        }
    }
}
