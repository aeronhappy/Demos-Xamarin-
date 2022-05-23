using Demos.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Services.Interfaces
{
    
    public interface IWordofthedayRepository
    {
        Task<WordOfTheDay> GetWordoftheday();
    } 
}
