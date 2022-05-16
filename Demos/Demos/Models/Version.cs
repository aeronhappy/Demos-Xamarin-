using System;
using System.Collections.Generic;
using System.Text;
using Demos.ViewModels;

namespace Demos.Models
{
    public class Version : ViewModelBase
    {
        public string verse{ get; set; }

        private string filenames;
        public string filename
        {
            get { return filenames; }
            set { SetProperty(ref filenames, value); }
        }
    }
}
