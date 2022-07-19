using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Implements.Requests;
using MonoBankApi.Models.Responses;
using MonoBankApi.Services;

namespace MonoBankApi.Implements
{
    public class MonoPersonal : IMonoPersonal
    {
        private readonly MonoApiContext _context;

        public MonoPersonal(MonoApiContext context)
        {
            _context = context;
        }

        public async Task<WebhookStatus> SetWebHookAsync(string webhookUrl) =>
            await _context.HttpPostAsync<WebhookStatus>(new WebhookRequest(webhookUrl));

        public async Task<ClientInfoResponse> ReturnClientInfoAsync() =>
            await _context.HttpGetAsync<ClientInfoResponse>(new ClientInfoRequest());

        public async Task<ICollection<StatementResponse>> ReturnStatementAsync(DateTime from, DateTime to, string acc = "0") =>
            await _context.HttpGetAsync<ICollection<StatementResponse>>(new StatementRequest(from, to, acc));
    }
}
