using System.Collections.Generic;
using MonoBankApi.Helper;
using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class ClientInfoResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accounts")]
        public ICollection<Account> Accounts { get; set; }
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

        // custom properties
        [JsonProperty("currencySymbol")]
        public string CurrencySymbol => Iso4217Codes.GetSimbolByCode(CurrencyCode);

        [JsonProperty("currencyName")]
        public string CurrencyName => Iso4217Codes.GetCurrencyNameByCode(CurrencyCode);

    }
}
