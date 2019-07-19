using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;
using MonoBankApi.Services;

namespace MonoBankApi.Implements
{
    public class MonoPublic : MonoClient, IMonoPublic
    {
        public MonoPublic() : base() { }

        public async Task<ICollection<CurrencyInfoResponse>> ReturnCurrencyInfoAsync() =>
            await HttpGetAsync<ICollection<CurrencyInfoResponse>>(new CurrencyInfoRequest());
    }
}
