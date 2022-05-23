using Demos.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Models
{
    public class WordOfTheDay : ViewModelBase
    {
        public int Id { get; set; }
        public string Verse { get; set; }
        public bool IsWordOfTheDay { get; set; }
        public string Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
