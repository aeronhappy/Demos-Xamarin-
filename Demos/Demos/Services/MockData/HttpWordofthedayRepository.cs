using Demos.Models;
using Demos.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;



namespace Demos.Services.MockData
{
    public class HttpWordofthedayRepository : IWordofthedayRepository
    {
        public async Task<WordOfTheDay> GetWordoftheday()
        {
            try
            {
                //Creating a request
                
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "api/Daily/WordOfTheDay");
                request.Version = new System.Version("1.0");

                //Sending the request
                HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return null;
                }
                else if (response.IsSuccessStatusCode)
                {

                    HttpContent content = response.Content;

                    string contentAsString = await content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<WordOfTheDay>(contentAsString);

                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
