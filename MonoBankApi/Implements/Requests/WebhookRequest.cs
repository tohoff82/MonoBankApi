using MonoBankApi.Models.RequestBodyes;

namespace MonoBankApi.Implements.Requests
{
    public class WebhookRequest : MonoRequest
    {
        public WebhookRequest(string webhookUrl)
        {
            sb.Append("/personal/webhook");
            bodyObj = new WebhookBody { WebHookUrl = webhookUrl };
        }
    }
}
