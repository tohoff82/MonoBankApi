using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi
{
    public interface IMonoPublic : IDisposable
    {
        /// <summary>
        /// Отримати базовий перелік курсів валют 
        /// </summary>
        /// <returns>List of CurrencyInfoResponse</returns>
        Task<List<CurrencyInfoResponse>> ReturnCurrencyInfo();
    }
}
