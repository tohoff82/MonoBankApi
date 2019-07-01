using Newtonsoft.Json

namespace MonoBankApi.Models.Responses
{
    public class CurrencyInfo
    {
        [JsonProperty("currencyCodeA")]
        public int CurrencyCodeA { get; set; }

        [JsonProperty("currencyCodeB")]
        public int CurrencyCodeB { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("rateSell")]
        public int RateSell { get; set; }

        [JsonProperty("rateBuy")]
        public int RateBuy { get; set; }

        [JsonProperty("rateCross")]
        public int RateCross { get; set; }
    }
}
