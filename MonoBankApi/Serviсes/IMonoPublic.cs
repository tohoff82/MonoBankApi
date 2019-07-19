using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Services
{
    public interface IMonoPublic
    {
        /// <summary>
        /// Отримати базовий перелік курсів валют 
        /// </summary>
        /// <returns>List of CurrencyInfoResponse</returns>
        Task<ICollection<CurrencyInfoResponse>> ReturnCurrencyInfoAsync();
    }
}
