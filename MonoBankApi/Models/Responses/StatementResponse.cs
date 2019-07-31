﻿using MonoBankApi.Helper;
using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class StatementResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("hold")]
        public bool Hold { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("operationAmount")]
        public long OperationAmount { get; set; }

        [JsonProperty("currencyCode")]
        public int CurrencyCode { get; set; }

        [JsonProperty("commissionRate")]
        public long CommissionRate { get; set; }

        [JsonProperty("cashbackAmount")]
        public long CashbackAmount { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        // custom properties
        [JsonProperty("currencySymbol")]
        public string CurrencySymbol
            => Iso4217Codes.GetSymbolByCode(CurrencyCode);

        [JsonProperty("mccDescription")]
        public string MccDescription
            => Iso18245Mcc.GetCategoryNameByCode(Mcc);
    }
}
