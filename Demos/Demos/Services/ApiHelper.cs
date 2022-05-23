using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace Demos.Services
{
    public static class ApiHelper
    {

        public static HttpClient AzureClient { get; set; }
        public static Uri AzureBaseAddress
        {
            get { return new Uri("https://theonebibleapp.azurewebsites.net/"); }
        }

        public static void InitializeAzureClient(string token)
        {
            AzureClient = new HttpClient();
            AzureClient.Timeout = TimeSpan.FromSeconds(20);
            AzureClient.BaseAddress = AzureBaseAddress;
            AzureClient.DefaultRequestHeaders.Clear();
            AzureClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            AzureClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
    }
