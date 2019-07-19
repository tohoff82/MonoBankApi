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
        private readonly string baseEndpoint = "https://api.monobank.ua";
        private readonly string webhookEndpoint = "personal/webhook";

        public MonoClient() => httpClient = new HttpClient { BaseAddress = new Uri(baseEndpoint) };
        public MonoClient(string token) : this() => httpClient.DefaultRequestHeaders.Add("X-Token", token);

        protected async Task<T> HttpGetAsync<T>(MonoRequest request)
        {
            using (var response = await httpClient.GetAsync(request.Url))
            {
                return await UnpackingResponseAsync<T>(response);
            }                
        }

        protected async Task<bool> WebhookAsync(string whUrl)
        {
            // string body = JsonConvert.SerializeObject(new { webHookUrl = whUrl });
            // var uri = new Uri(webhookEndpoint, UriKind.Relative);

            using (var response = await httpClient.PostAsync(
                new Uri(webhookEndpoint, UriKind.Relative),
                new StringContent(JsonConvert.SerializeObject(
                    new { webHookUrl = whUrl }))))
            {
                return response.IsSuccessStatusCode;
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
