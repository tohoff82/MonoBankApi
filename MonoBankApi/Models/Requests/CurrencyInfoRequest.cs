using System.Text;

namespace MonoBankApi.Models.Requests
{
    public class CurrencyInfoRequest : MonoRequest
    {
        private const string path = "/bank/currency";

        public override string Url()
        {
            var sb = new StringBuilder(path);

            return sb.ToString();
        }
    }
}
