using System;
using MonoBankApi.Models.RequestBodyes;

namespace MonoBankApi.Models.Requests
{
    public class WebhookRequest : MonoRequest
    {
        public WebhookRequest(string webhookUrl) =>
            bodyObj = new WebhookBody
            {
                WebHookUrl = webhookUrl
            };

        protected override Uri GetUri() =>
            new Uri("/personal/webhook", UriKind.Relative);
    }
}
