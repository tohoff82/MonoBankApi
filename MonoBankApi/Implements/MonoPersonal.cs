using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;
using MonoBankApi.Services;

namespace MonoBankApi.Implements
{
    public class MonoPersonal : MonoClient, IMonoPersonal
    {
        public MonoPersonal(string token) : base(token) { }

        public async Task<bool> SetWebHookAsync(string webhookUrl) =>
            await WebhookAsync(webhookUrl);

        public async Task<ClientInfoResponse> ReturnClientInfoAsync() =>
            await HttpGetAsync<ClientInfoResponse>(new ClientInfoRequest());

        public async Task<ICollection<StatementResponse>> ReturnStatementAsync(DateTime from, DateTime to, string acc = "0") =>
            await HttpGetAsync<ICollection<StatementResponse>>(new StatementRequest(from, to, acc));
    }
}
