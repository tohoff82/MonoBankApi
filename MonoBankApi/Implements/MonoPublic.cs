using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Implements.Requests;
using MonoBankApi.Models.Responses;
using MonoBankApi.Services;

namespace MonoBankApi.Implements
{
    public class MonoPublic : MonoHttp, IMonoPublic
    {
        public MonoPublic() : base() { }

        public async Task<ICollection<CurrencyInfoResponse>> ReturnCurrencyInfoAsync() =>
            await HttpGetAsync<ICollection<CurrencyInfoResponse>>(new CurrencyInfoRequest());
    }
}
