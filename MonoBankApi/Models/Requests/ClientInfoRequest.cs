using System.Text;

namespace MonoBankApi.Models.Requests
{
    class ClientInfoRequest : MonoRequest
    {
        private const string path = "/personal/client-info";

        public override string Url()
        {
            var sb = new StringBuilder(path);

            return sb.ToString();
        }
    }
}
