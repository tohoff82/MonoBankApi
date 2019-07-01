using System;
using System.Text;

namespace MonoBankApi.Models.Requests
{
    public class StatementRequest : MonoRequest
    {
        private readonly string to;
        private readonly string from;
        private readonly string account;
        private readonly string path = "/personal/statement";

        public StatementRequest(DateTime from, DateTime to, string account)
        {
            this.account = account;
            this.to = ((DateTimeOffset)to).ToUnixTimeSeconds().ToString();
            this.from = ((DateTimeOffset)from).ToUnixTimeSeconds().ToString();
        }

        protected override string GetUrl()
        {
            var sb = new StringBuilder(path);

            return sb.AppendFormat("/{0}", account)
                    .AppendFormat("/{0}", from)
                    .AppendFormat("/{0}", to)
                    .ToString();
        }
    }
}
