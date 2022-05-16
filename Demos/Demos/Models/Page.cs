using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demos.Models
{
    public class Page<T>
    {
        public ObservableCollection<T> Data { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public string PreviousPage { get; set; }
        public string NextPage { get; set; }
    }
}
