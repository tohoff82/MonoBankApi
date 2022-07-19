using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MonoBankApi.Exceptions;
using MonoBankApi.Implements.Requests;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Implements
{
    public class MonoApiContext
    {
        private readonly HttpClient _httpClient;
        private readonly string _shema = "application/json";

        public MonoApiContext(HttpClient httpClient)
       {
            _httpClient = httpClient;
        }

        public async Task<T> HttpGetAsync<T>(MonoRequest request)
        {
            using (var response = await _httpClient.GetAsync(request.Uri).ConfigureAwait(false))
            {
                return await UnpackingResponseAsync<T>(response);
            }                
        }

        public async Task<T> HttpPostAsync<T>(MonoRequest request)
        {
            using (var response = await _httpClient.PostAsync(request.Uri,
                new StringContent(request.Body, Encoding.UTF8, _shema)).ConfigureAwait(false))
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
