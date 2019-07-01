using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Responses;

namespace MonoBankApi
{
    public interface IMonoPublic : IDisposable
    {
        Task<List<CurrencyInfoResponse>> ReturnCurrencyInfo();
    }
}
