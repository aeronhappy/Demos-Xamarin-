using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Models
{
    public class Pastor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ImageProfile { get; set; }
        public string Church { get; set; }
        public string Message { get; set; }
        public string YoutubeLink { get; set; }
        public string FacebookLink { get; set; }
        public List<Book> Books { get; set; }
    }
}
