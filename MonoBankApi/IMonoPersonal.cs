using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi
{
    public interface IMonoPersonal : IDisposable
    {
        /// <summary>
        /// Отримання інформації про клієнта та переліку його рахунків
        /// </summary>
        /// <returns>ClientInfoResponse</returns>
        Task<ClientInfoResponse> ReturnClientInfoAsync();

        /// <summary>
        /// Отримання виписки за період
        /// </summary>
        /// <param name="from">час початку вибірки</param>
        /// <param name="to">час кінця вибірки</param>
        /// <param name="acc">Ідентифікатор рахунку, 0 - дефолтний рахунок</param>
        /// <returns>List of StatementResponse</returns>
        Task<List<StatementResponse>> ReturnStatementAsync(DateTime from, DateTime to, string acc = "0");
    }
}
