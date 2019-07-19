using Newtonsoft.Json;

namespace MonoBankApi.Models.RequestBodyes
{
    public class WebhookBody
    {
        [JsonProperty("webHookUrl")]
        public string WebHookUrl { get; set; }
    }
}
