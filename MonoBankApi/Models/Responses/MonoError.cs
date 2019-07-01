using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class MonoError
    {
        [JsonProperty("errorDescription")]
        public string Description { get; set; }
    }
}
