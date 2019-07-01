using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Implements
{
    public class MonoPersonal : MonoClient, IMonoPersonal
    {
        public MonoPersonal(string token) : base(token) { }

        public async Task<ClientInfoResponse> ReturnClientInfo() =>
            await HttpGetAsync<ClientInfoResponse>(new ClientInfoRequest());

        public async Task<List<StatementResponse>> ReturnStatement(string from, string to, string acc = "0") =>
            await HttpGetAsync<List<StatementResponse>>(new StatementRequest(from, to, acc));
    }
}
