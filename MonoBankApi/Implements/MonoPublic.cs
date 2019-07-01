using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Implements
{
    public class MonoPublic : MonoClient, IMonoPublic
    {
        public MonoPublic() : base() { }

        public async Task<List<CurrencyInfoResponse>> ReturnCurrencyInfo() =>
            await HttpGetAsync<List<CurrencyInfoResponse>>(new CurrencyInfoRequest());
    }
}
