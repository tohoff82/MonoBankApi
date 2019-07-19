using System;
using System.Text;

namespace MonoBankApi.Implements.Requests
{
    public class StatementRequest : MonoRequest
    {
        private readonly string path = string.Empty;

        public StatementRequest(DateTime from, DateTime to, string account)
        {
            var sb = new StringBuilder("/personal/statement");

            sb.AppendFormat("/{0}", account)
             .AppendFormat("/{0}", ((DateTimeOffset)from).ToUnixTimeSeconds().ToString())
             .AppendFormat("/{0}", ((DateTimeOffset)to).ToUnixTimeSeconds().ToString());

            path = sb.ToString();
        }

        protected override Uri GetUri() =>
            new Uri(path, UriKind.Relative);
    }
}
