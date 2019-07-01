using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MonoBankApi.Models.Requests;

namespace MonoBankApi
{
    public abstract class MonoClient
    {
        private readonly HttpClient httpClient;
        private readonly string baseAdress = "https://api.monobank.ua";

        public MonoClient() => httpClient = new HttpClient { BaseAddress = new Uri(baseAdress) };
        public MonoClient(string token) : this() => httpClient.DefaultRequestHeaders.Add("X-Token", token);

        protected async Task<T> HttpGetAsync<T>(MonoRequest request)
        {
            var response = await httpClient.GetAsync(request.Url).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            return await UnpackingResponseAsync<T>(response);
        }

        private async Task<T> UnpackingResponseAsync<T>(HttpResponseMessage responseMessage)
        {
            string json = await responseMessage.Content.ReadAsStringAsync();
            return await Task.Run(() => JsonConvert.DeserializeObject<T>(json));
        }

        public void Dispose() => httpClient.Dispose();
    }
}
