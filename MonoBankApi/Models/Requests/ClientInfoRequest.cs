using System.Text;

namespace MonoBankApi.Models.Requests
{
    class ClientInfoRequest : MonoRequest
    {
        private const string path = "/personal/client-info";

        protected override string GetUrl()
        {
            var sb = new StringBuilder(path);

            return sb.ToString();
        }
    }
}
