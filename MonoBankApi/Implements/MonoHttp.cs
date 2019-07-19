using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MonoBankApi.Exceptions;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Implements
{
    public abstract class MonoHttp
    {
        private readonly HttpClient httpClient;
        private readonly string baseEndpoint = "https://api.monobank.ua";

        public MonoHttp() => httpClient = new HttpClient { BaseAddress = new Uri(baseEndpoint) };
        public MonoHttp(string token) : this() => httpClient.DefaultRequestHeaders.Add("X-Token", token);

        protected async Task<T> HttpGetAsync<T>(MonoRequest request)
        {
            using (var response = await httpClient.GetAsync(request.Uri))
            {
                return await UnpackingResponseAsync<T>(response);
            }                
        }

        protected async Task<T> HttpPostAsync<T>(MonoRequest request)
        {
            using (var response = await httpClient.PostAsync(request.Uri,
                new StringContent(request.Body, Encoding.UTF8, "application/json")))
            {
                return await UnpackingResponseAsync<T>(response);
            }
        }

        private async Task<T> UnpackingResponseAsync<T>(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();

            CheckStatus(response.IsSuccessStatusCode, json);

            return JsonConvert.DeserializeObject<T>(json);
        }
        private void CheckStatus(bool is200_OK, string json)
        {
            if (!is200_OK)
            {
                var err = JsonConvert.DeserializeObject<MonoError>(json);
                throw new MonoException(err.Description);
            }
        }
    }
}
