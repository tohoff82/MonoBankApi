using Newtonsoft.Json;

namespace MonoBankApi.Models.Responses
{
    public class StatementResponse
    {
        public string Id            { get; set; }

        /// <summary>
        /// Transaction time in seconds in Unix time format
        /// </summary>
        /// <value></value>
        [JsonProperty("time")]
        public int Timestamp        { get; set; }
        public int Mcc              { get; set; }
        public int OriginalMcc      { get; set; }
        public bool Hold            { get; set; }
        public long Amount          { get; set; }
        public long OperationAmount { get; set; }
        public int CurrencyCode     { get; set; }
        public long CommissionRate  { get; set; }
        public long CashbackAmount  { get; set; }
        public long Balance         { get; set; }
        public string Description   { get; set; }
        public string Comment       { get; set; }
        public string ReceiptId     { get; set; }
        public string InvoiceId     { get; set; }
        public string CounterEdrpou { get; set; }
        public string CounterIban   { get; set; }
    }
}
