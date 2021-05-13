using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DndMagicLibrary.Data.Api
{
    public class ApiHelper : IApiHelper
    {
        public ApiHelper(HttpClient client)
        {
            ApiClient = client;
            InitializeClient(ApiClient);
        }

        public HttpClient ApiClient { get; set; }
        public void InitializeClient(HttpClient client)
        {
            client.BaseAddress = new Uri("http://www.dnd5eapi.co/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }

    public interface IApiHelper
    {
        HttpClient ApiClient { get; set; }

        void InitializeClient(HttpClient client);
    }
}