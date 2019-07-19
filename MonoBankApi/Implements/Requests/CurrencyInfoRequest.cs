using System;

namespace MonoBankApi.Implements.Requests
{
    public class CurrencyInfoRequest : MonoRequest
    {
        protected override Uri GetUri() =>
            new Uri("/bank/currency", UriKind.Relative);
    }
}
