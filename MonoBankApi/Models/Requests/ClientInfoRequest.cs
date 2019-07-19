using System;

namespace MonoBankApi.Models.Requests
{
    class ClientInfoRequest : MonoRequest
    {
        protected override Uri GetUri() =>
            new Uri("/personal/client-info", UriKind.Relative);
    }
}
