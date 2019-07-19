using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MonoBankApi.Exceptions;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Implements
{
    public abstract class MonoClient
    {
        private readonly HttpClient httpClient;
        private readonly string baseAdress = "https://api.monobank.ua";

        public MonoClient() => httpClient = new HttpClient { BaseAddress = new Uri(baseAdress) };
        public MonoClient(string token) : this() => httpClient.DefaultRequestHeaders.Add("X-Token", token);

        protected async Task<T> HttpGetAsync<T>(MonoRequest request)
        {
            var response = await httpClient.GetAsync(request.Url);

            return await UnpackingResponseAsync<T>(response);
        }

        private async Task<T> UnpackingResponseAsync<T>(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();

            CheckStatus(response.IsSuccessStatusCode, json);
            response.Dispose();

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
