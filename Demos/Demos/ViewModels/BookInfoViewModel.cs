using Demos.Models;
using Demos.Services.Interfaces;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demos.ViewModels
{
    [QueryProperty(nameof(PastorId), nameof(PastorId))]
    [QueryProperty(nameof(BookId), nameof(BookId))]
    public class BookInfoViewModel : ViewModelBase
    {
        public string PastorId { get; set; }
        public string BookId { get; set; }

        //DATA
        private Pastor pastor;
        public Pastor Pastor
        {
            get { return pastor; }
            set { SetProperty(ref pastor, value); }
        }

        private Book book;
        public Book Book
        {
            get { return book; }
            set { SetProperty(ref book, value); }
        }


        private readonly IDataRepository pastorRepository;

        //COMMANDS
        public AsyncCommand AppearingCommand { get; set; }
        public AsyncCommand NextCommand { get; set; }
        public AsyncCommand PreviousCommand { get; set; }

        public BookInfoViewModel()
        {
            AppearingCommand = new AsyncCommand(OnAppearingAsync);
            NextCommand = new AsyncCommand(OnNextClickedAsync);
            PreviousCommand = new AsyncCommand(OnPreviousClickedAsync);
            pastorRepository = DependencyService.Get<IDataRepository>();
        }

        private async Task OnPreviousClickedAsync()
        {
            try
            {
                Book = Pastor.Books[Pastor.Books.IndexOf(Book) - 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                Book = Pastor.Books[Pastor.Books.Count - 1];
            }
            
        }

        private async Task OnNextClickedAsync()
        {
            try
            {
                Book = Pastor.Books[Pastor.Books.IndexOf(Book) + 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                Book = Pastor.Books[0];    
            }
        }

        private async Task OnAppearingAsync()
        {
            Pastor = pastorRepository.GetPastorById(Convert.ToInt32(PastorId));
            Book = Pastor.Books.Where(b => b.Id == Convert.ToInt32(BookId)).FirstOrDefault();
        }
    }
}
