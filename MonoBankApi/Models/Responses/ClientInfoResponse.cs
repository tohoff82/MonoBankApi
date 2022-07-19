using System.Collections.Generic;

namespace MonoBankApi.Models.Responses
{
    public class ClientInfoResponse
    {
        public string ClientId    { get; set; }
        public string Name        { get; set; }
        public string WebhookUrl  { get; set; }
        public string Permissions { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<Jar> Jars { get; set; }
    }

    public class Account
    {
        public string Id { get; set; }

        /// <summary>
        /// Service identifier for https://send.monobank.ua/{sendId}
        /// </summary>
        /// <value></value>
        public string SendId    { get; set; }
        public long Balance     { get; set; }
        public long CreditLimit { get; set; }
        public int CurrencyCode { get; set; }
        /// <summary>
        /// Enum: "black" "white" "platinum" "iron" "fop" "yellow" "eAid"
        /// </summary>
        /// <value></value>
        public string Type { get; set; }

        /// <summary>
        /// Enum: "None" "UAH" "Miles"
        /// </summary>
        /// <value></value>
        public string CashbackType { get; set; }

        /// <summary>
        /// List of masked card numbers (premium cards may have more than one)
        /// </summary>
        /// <value></value>
        public string[] MaskedPan { get; set; }
        public string Iban      { get; set; }
    }

    public class Jar
    {
        public string Id { get; set; }

        /// <summary>
        /// Service identifier for https://send.monobank.ua/{sendId}
        /// </summary>
        /// <value></value>
        public string SendId      { get; set; }
        public string Title       { get; set; }
        public string Description { get; set; }
        public int CurrencyCode   { get; set; }
        public long Balance       { get; set; }
        public string Goal        { get; set; }
    }
}
