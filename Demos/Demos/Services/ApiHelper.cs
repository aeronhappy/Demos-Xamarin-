using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace Demos.Services
{
    public static class ApiHelper
    {
        public static HttpClient Client { get; set; }

        public static Uri BaseAddress
        {
            get { return new Uri("https://theonebibleapp.com/"); }
        }

        public static Uri UnsecureBaseAddress
        {
            get { return new Uri("http://api.theonebibleapp.com/"); }
        }

        public static HttpClient AzureClient { get; set; }
        public static Uri AzureBaseAddress { get { return new Uri("https://theonebibleapp.azurewebsites.net/"); } }

        public static void InitializeClient()
        {
            Client = new HttpClient();
            Client.Timeout = TimeSpan.FromSeconds(20);
            Client.BaseAddress = BaseAddress;
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static void InitializeAzure(string token)
        {
            AzureClient = new HttpClient();
            AzureClient.Timeout = TimeSpan.FromSeconds(20);
            AzureClient.BaseAddress = AzureBaseAddress;
            AzureClient.DefaultRequestHeaders.Clear();
            AzureClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            AzureClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public static void InitializeHttpClient()
        {
            Client = new HttpClient();
            Client.Timeout = TimeSpan.FromSeconds(20);
            Client.BaseAddress = UnsecureBaseAddress;
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
