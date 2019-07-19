using System;

namespace MonoBankApi.Models.Requests
{
    public class CurrencyInfoRequest : MonoRequest
    {
        protected override Uri GetUri() =>
            new Uri("/bank/currency", UriKind.Relative);
    }
}
