using Demos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demos.Services.Interfaces
{
    public interface IDataRepository
    {
        ObservableCollection<Pastor> GetPastors();
        Pastor GetPastorById(int id);
        Pastor GetNextPastor(Pastor pastor);
        Pastor GetPreviewsPastor(Pastor pastor);
        ObservableCollection<Music> GetMusics();
        ObservableCollection<Music> GetFilteredMusic(string filterData);
    }
}
