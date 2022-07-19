using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Services
{
    public interface IMonoPublic
    {
        /// <summary>
        /// Get a basic list of exchange rates
        /// </summary>
        /// <returns>List of CurrencyInfoResponse</returns>
        Task<IEnumerable<CurrencyInfoResponse>> ReturnCurrencyInfoAsync();
    }
}
