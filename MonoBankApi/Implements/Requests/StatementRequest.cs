using System;

namespace MonoBankApi.Implements.Requests
{
    public class StatementRequest : MonoRequest
    {
        public StatementRequest(DateTime from, DateTime to, string account)
        {
            if (string.IsNullOrEmpty(account))
                throw new ArgumentException("Account must be not null or empty", nameof(account));

            sb.Append("/personal/statement")
             .AppendFormat("/{0}", account)
             .AppendFormat("/{0}", ((DateTimeOffset)from).ToUnixTimeSeconds().ToString())
             .AppendFormat("/{0}", ((DateTimeOffset)to).ToUnixTimeSeconds().ToString());
        }
    }
}
