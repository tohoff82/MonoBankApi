using Newtonsoft.Json;

namespace MonoBankApi.Models.ISO
{
    public class MerchantCategoryCode
    {
        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("mcc")]
        public string Description { get; set; }
    }
}
