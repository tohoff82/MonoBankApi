using System.Collections.Generic;
using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class UserInfoResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accounts")]
        public List<Account> Accounts { get; set; }
    }

    public class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("creditLimit")]
        public long CreditLimit { get; set; }

        [JsonProperty("currencyCode")]
        public int CurrencyCode { get; set; }

        [JsonProperty("cashbackType")]
        public string CashbackType { get; set; } // None, UAH, Miles
    }
}
