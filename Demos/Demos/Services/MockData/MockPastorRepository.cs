using Demos.Models;
using Demos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Demos.Services.MockData
{
    public class MockPastorRepository : IDataRepository
    {
        ObservableCollection<Pastor> Pastors { get; set; }
        ObservableCollection<Music> Musics { get; set; }

        public MockPastorRepository()
        {
            Pastors = new ObservableCollection<Pastor>()
            {
                new Pastor
                {
                    Id = 1, FullName = "Erick Maligaya",
                    ImageProfile = "pastor.jpg",
                    Church = "Mabacan Calauan Laguna",
                    Message = "Masama Magnakaw",
                    FacebookLink = "www.facebook.com",
                    YoutubeLink = "youtube.com",
                    Books = new List<Book>()
                    {
                        new Book{ Id = 1, Title = "Bahaghari", YearOfPublication = 1999},
                        new Book{ Id = 2, Title = "Ibong Adarna", YearOfPublication = 1945},
                        new Book{ Id = 3, Title = "Isabel", YearOfPublication = 1956},
                    }
                },
                new Pastor
                { 
                    Id = 2,
                    FullName = "Junior Maligaya", 
                    ImageProfile = "pastor.jpg", 
                    Church = "Pook Calauan Laguna", 
                    Message = "Masama Magnakaw",
                    FacebookLink = "www.facebook.com",
                    YoutubeLink = "youtube.com",
                    Books = new List<Book>()
                    {
                        new Book{ Id = 1, Title = "Bahaghari", YearOfPublication = 1999},
                        new Book{ Id = 2, Title = "Ibong Adarna", YearOfPublication = 1945},        
                    }
                },
                new Pastor
                { 
                    Id = 3, 
                    FullName = "Kyle Maligaya", 
                    ImageProfile = "pastor.jpg", 
                    Church = "Perez Calauan Laguna", 
                    Message = "Masama Magnakaw",
                    FacebookLink = "www.facebook.com",
                    YoutubeLink = "youtube.com",
                    Books = new List<Book>()
                    {
                        new Book{ Id = 1, Title = "Bahaghari", YearOfPublication = 1999},  
                    }
                },
                new Pastor
                { 
                    Id = 4, 
                    FullName = "Arjay Maligaya", 
                    ImageProfile = "pastor.jpg", 
                    Church = "SanPablo Calauan Laguna", 
                    Message = "Masama Magnakaw" ,
                    FacebookLink = "www.facebook.com",
                    YoutubeLink = "youtube.com",
                    Books = new List<Book>()
                    {
                        new Book{ Id = 1, Title = "Bahaghari", YearOfPublication = 1999},
                        new Book{ Id = 2, Title = "Ibong Adarna", YearOfPublication = 1945},
                        new Book{ Id = 3, Title = "Isabel", YearOfPublication = 1956}
                    }
                },
                new Pastor
                { 
                    Id = 5, 
                    FullName = "Gicelle Maligaya", 
                    ImageProfile = "pastor.jpg", 
                    Church = "Central Calauan Laguna", 
                    Message = "Masama Magnakaw",
                    FacebookLink = "www.facebook.com",
                    YoutubeLink = "youtube.com",
                    Books = new List<Book>()
                    {
                        new Book{ Id = 1, Title = "Bahaghari", YearOfPublication = 1999},
                        new Book{ Id = 2, Title = "Ibong Adarna", YearOfPublication = 1945},
                        new Book{ Id = 3, Title = "Isabel", YearOfPublication = 1956},
                        new Book{ Id = 4, Title = "Alamat", YearOfPublication = 1989},
                        new Book{ Id = 5, Title = "Correy", YearOfPublication = 2000},
                    }
                },
                new Pastor
                { 
                    Id = 6, 
                    FullName = "Krystel Maligaya", 
                    ImageProfile = "pastor.jpg", 
                    Church = "Tubero Calauan Laguna", 
                    Message = "Masama Magnakaw",
                    FacebookLink = "www.facebook.com",
                    YoutubeLink = "youtube.com",
                    Books = new List<Book>()
                    {
                        new Book{ Id = 1, Title = "Bahaghari", YearOfPublication = 1999},
                        new Book{ Id = 2, Title = "Ibong Adarna", YearOfPublication = 1945},
                        new Book{ Id = 3, Title = "Isabel", YearOfPublication = 1956}
                    }
                },
            };

            Musics = new ObservableCollection<Music>()
            {
                new Music(){ Id = 1, Title = "Nang Dumating Ka", Artist = "Bandang Lapis", ReleaseDate = 1999 },
                new Music(){ Id = 2, Title = "Lagi", Artist = "Scusta Clee", ReleaseDate = 2000 },
                new Music(){ Id = 3, Title = "Byahe", Artist = "Mashup", ReleaseDate = 1980 },
                new Music(){ Id = 4, Title = "Pagsamo", Artist = "Arthur Miguel", ReleaseDate = 2004 },
                new Music(){ Id = 5, Title = "MAPA", Artist = "Sam Mangubat Cover", ReleaseDate = 2006 },
                new Music(){ Id = 6, Title = "Kabilang Buhay", Artist = "Tyrone", ReleaseDate = 2021 },
                new Music(){ Id = 7, Title = "Titig", Artist = "Mashup", ReleaseDate = 2020 },
                new Music(){ Id = 8, Title = "Imahe", Artist = "Magnus Heaven", ReleaseDate = 2019 },
                new Music(){ Id = 9, Title = "Hate", Artist = "Michael Pacquiao", ReleaseDate = 2006 },
                new Music(){ Id = 10, Title = "Sobra ng Sakit", Artist = "Joms", ReleaseDate = 2005 },
                new Music(){ Id = 11, Title = "Selos kana naman", Artist = "sevenjc", ReleaseDate = 2007 },
                new Music(){ Id = 12, Title = "Pasensya kana", Artist = "Kabilang buhay", ReleaseDate = 2001 },
                new Music(){ Id = 13, Title = "Bumalik kana", Artist = "Skusta Clee", ReleaseDate = 2000 },
                new Music(){ Id = 14, Title = "Hindi pa huli", Artist = "Sevenjec", ReleaseDate = 2011 },
                new Music(){ Id = 15, Title = "Baka di tayo", Artist = "420 soldiers", ReleaseDate = 2013 },
                new Music(){ Id = 16, Title = "Kung tayo", Artist = "Scusta Clee", ReleaseDate = 2015 },
                new Music(){ Id = 17, Title = "Miloves", Artist = "King Badger", ReleaseDate = 2018 },
                new Music(){ Id = 18, Title = "Salamat Dumating ka", Artist = "Hydro", ReleaseDate = 2010 },
                new Music(){ Id = 19, Title = "Goldings", Artist = "Henyong makata", ReleaseDate = 2014 },
                new Music(){ Id = 20, Title = "Sulyap", Artist = "Moira Dela Tore", ReleaseDate = 2009 },
            };

        }

        public Pastor GetPastorById(int id)
        {
            return Pastors.FirstOrDefault(p => p.Id == id);
        }

        public ObservableCollection<Pastor> GetPastors()
        {
            return Pastors;
        }

        public Pastor GetNextPastor(Pastor pastor)
        {
            int nextPastor = Pastors.IndexOf(pastor) + 1;
            return Pastors[nextPastor];
        }

        public Pastor GetPreviewsPastor(Pastor pastor)
        {
            int previewsPastor = Pastors.IndexOf(pastor) - 1;
            return Pastors[previewsPastor];
        }

        public ObservableCollection<Music> GetMusics()
        {
            return Musics;
        }

        public ObservableCollection<Music> GetFilteredMusic(string filterData)
        {
            return new ObservableCollection<Music>(Musics.Where(s => s.Title.ToLower().Contains(filterData.ToLower()) || s.Artist.ToLower().Contains(filterData.ToLower())));
        }
    }
}
