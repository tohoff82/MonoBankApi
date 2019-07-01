using System.Text;

namespace MonoBankApi.Models.Requests
{
    public class StatementRequest : MonoRequest
    {
        private readonly string to;
        private readonly string from;
        private readonly string account;
        private readonly string path = "/personal/statement";

        public StatementRequest(string from, string to, string account)
        {
            this.to = to;
            this.from = from;
            this.account = account;
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
