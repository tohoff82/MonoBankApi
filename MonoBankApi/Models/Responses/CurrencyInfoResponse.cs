using MonoBankApi.Helper;
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

        // custom properties
        [JsonProperty("currencySymbolA")]
        public string CurrencySymbolA
            => Iso4217Codes.GetSymbolByCode(CurrencyCodeA);

        [JsonProperty("currencySymbolB")]
        public string CurrencySymbolB
            => Iso4217Codes.GetSymbolByCode(CurrencyCodeB);

        [JsonProperty("currencyNameA")]
        public string CurrencyNameA
            => Iso4217Codes.GetNameByCode(CurrencyCodeA);

        [JsonProperty("currencyNameB")]
        public string CurrencyNameB
            => Iso4217Codes.GetNameByCode(CurrencyCodeB);
    }
}
