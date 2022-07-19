using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class CurrencyInfoResponse
    {
        public int CurrencyCodeA { get; set; }
        public int CurrencyCodeB { get; set; }

        /// <summary>
        /// Course time in seconds in Unix time format
        /// </summary>
        /// <value></value>
        [JsonProperty("date")]
        public int Timestamp   { get; set; }
        public float RateSell  { get; set; }
        public float RateBuy   { get; set; }
        public float RateCross { get; set; }
    }
}
