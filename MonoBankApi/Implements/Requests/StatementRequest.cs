using System;

namespace MonoBankApi.Implements.Requests
{
    public class StatementRequest : MonoRequest
    {
        public StatementRequest(DateTime from, DateTime to, string account)
        {
            sb.Append("/personal/statement")
             .AppendFormat("/{0}", account)
             .AppendFormat("/{0}", ((DateTimeOffset)from).ToUnixTimeSeconds().ToString())
             .AppendFormat("/{0}", ((DateTimeOffset)to).ToUnixTimeSeconds().ToString());
        }
    }
}
