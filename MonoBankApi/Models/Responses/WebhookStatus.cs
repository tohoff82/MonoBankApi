using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class WebhookStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
