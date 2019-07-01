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
        Task<ClientInfoResponse> ReturnClientInfo();

        /// <summary>
        /// Отримання виписки за період
        /// </summary>
        /// <param name="from">часу в секундах в форматі Unix time</param>
        /// <param name="to">часу в секундах в форматі Unix time</param>
        /// <param name="acc">Ідентифікатор рахунку, 0 - дефолтний рахунок</param>
        /// <returns>List of StatementResponse</returns>
        Task<List<StatementResponse>> ReturnStatement(string from, string to, string acc = "0");
    }
}
