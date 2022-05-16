using Demos.Models;
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

    [QueryProperty(nameof(PastorId), nameof(PastorId))]
    public class PastorInfoViewModel : ViewModelBase
    {
        public string PastorId { get; set; }

        //DATA
        private Pastor pastor;
        public Pastor Pastor
        {
            get { return pastor; }
            set { SetProperty(ref pastor, value); }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get { return selectedBook; }
            set { SetProperty(ref selectedBook, value); }
        }


        //DATA ACCESS
        private readonly IDataRepository pastorRepository;

        //COMMAND
        public AsyncCommand AppearingCommand { get; set; }
        public AsyncCommand NextCommand { get; set; }
        public AsyncCommand PreviewsCommand { get; set; }
        public AsyncCommand SelectedBookCommand { get; set; }

        public PastorInfoViewModel()
        {
            Title = "Pastor Information";

            pastorRepository = DependencyService.Get<IDataRepository>();

            AppearingCommand = new AsyncCommand(OnAppearingAsync);
            NextCommand = new AsyncCommand(NextAsync);
            PreviewsCommand = new AsyncCommand(PreviewsAsync);
            SelectedBookCommand = new AsyncCommand(OnSelectAsync);
        }

        private async Task OnSelectAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(BookInfoPage)}?PastorId={Pastor.Id}&BookId={selectedBook.Id}");
        }

        private async Task PreviewsAsync()
        {
            Pastor = pastorRepository.GetPreviewsPastor(Pastor);
        }

        private async Task NextAsync()
        {
            Pastor = pastorRepository.GetNextPastor(Pastor);
        }

        private async Task OnAppearingAsync()
        {
            Pastor = pastorRepository.GetPastorById(Convert.ToInt32(PastorId));
        }
    }
}
