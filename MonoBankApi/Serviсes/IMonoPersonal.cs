using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Services
{
    public interface IMonoPersonal
    {
        /// <summary>
        /// Monobank WebHook message signature
        /// </summary>
        /// <param name="url">The address to which messages will be sent</param>
        /// <returns></returns>
        Task<WebhookStatus> SetWebHookAsync(string url);

        /// <summary>
        /// Obtaining information about the client and a list of his accounts
        /// </summary>
        /// <returns>ClientInfoResponse</returns>
        Task<ClientInfoResponse> ReturnClientInfoAsync();

        /// <summary>
        /// Receipt of statement for the period
        /// </summary>
        /// <param name="from">statement start time/param>
        /// <param name="to">statement finish time</param>
        /// <param name="acc">Іaccount Id</param>
        /// <returns>List of StatementResponse</returns>
        Task<ICollection<StatementResponse>> ReturnStatementAsync(DateTime from, DateTime to, string acc = default);
    }
}
