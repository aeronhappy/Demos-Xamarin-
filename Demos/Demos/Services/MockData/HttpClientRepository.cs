using Demos.Models;
using Demos.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Services.MockData
{
    public class HttpClientRepository : IHttpClientRepository
    {
        public async Task<Accounts> GetAccountsAsync()
        {
            try
            {
                //Creating a request
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "WebAPI/newapi/test/fetchusers.php");

                //Sending the request
                using (HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent content = response.Content;

                        string contentAsString = await content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Accounts>(contentAsString);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Chapter> GetVerse()
        {
            try
            {
                //Creating a request
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "test.php");

                //Sending the request
                using (HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent content = response.Content;

                        string contentAsString = await content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Chapter>(contentAsString);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Response> RegisterAsync(RegisterDto credentials)
        {

        //https://theonebibleapp.com/WebAPI/newapi/test/register.php

            try
            {
                string stringContent = JsonConvert.SerializeObject(credentials);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "WebAPI/newapi/test/register.php");
                request.Content = new StringContent(stringContent, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request)) 
                {
                    HttpContent content = response.Content;
                    string contentAsString = await content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Response>(contentAsString);
                };

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<VersionApp> GetVersion()
        {
            // http://api.theonebibleapp.com/theversioncont.php

            try
            {
                //Creating a request
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "theversioncont.php");

                //Sending the request
                using (HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent content = response.Content;

                        string contentAsString = await content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<VersionApp>(contentAsString);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Cool> GetCool()
        {
            // http://api.theonebibleapp.com/cool.php

            try
            {
                //Creating a request
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "cool.php");

                //Sending the request
                using (HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent content = response.Content;

                        string contentAsString = await content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Cool>(contentAsString);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Page<Community>> GetCommunity(int pageNumber, int pageSize)
        {
            try
            {
                //Creating a request
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"api/communities/all?pageNumber={pageNumber}&pageSize={pageSize}");

                //Sending the request
                using (HttpResponseMessage response = await ApiHelper.AzureClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent content = response.Content;

                        string contentAsString = await content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Page<Community>>(contentAsString);
                    }
                    else
                    {
                        return null;
                    }
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
