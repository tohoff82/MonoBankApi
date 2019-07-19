using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Services
{
    public interface IMonoPersonal
    {
        /// <summary>
        /// Підпис на повідомлення Monobank WebHook
        /// </summary>
        /// <param name="url">адреса на яку будуть надходити повідомлення</param>
        /// <returns></returns>
        Task<bool> SetWebHookAsync(string url);

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
        Task<ICollection<StatementResponse>> ReturnStatementAsync(DateTime from, DateTime to, string acc = "0");
    }
}
