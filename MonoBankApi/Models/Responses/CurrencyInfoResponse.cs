using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class CurrencyInfoResponse
    {
        [JsonProperty("currencyCodeA")]
        public int CurrencyCodeA { get; set; }

        [JsonProperty("currencyCodeB")]
        public int CurrencyCodeB { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("rateSell")]
        public float RateSell { get; set; }

        [JsonProperty("rateBuy")]
        public float RateBuy { get; set; }

        [JsonProperty("rateCross")]
        public float RateCross { get; set; }
    }
}
