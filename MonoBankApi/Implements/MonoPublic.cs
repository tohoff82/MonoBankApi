using System.Threading.Tasks;
using System.Collections.Generic;
using MonoBankApi.Implements.Requests;
using MonoBankApi.Models.Responses;
using MonoBankApi.Services;

namespace MonoBankApi.Implements
{
    public class MonoPublic : IMonoPublic
    {
        private readonly MonoApiContext _context;

        public MonoPublic(MonoApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CurrencyInfoResponse>> ReturnCurrencyInfoAsync() =>
            await  _context.HttpGetAsync<ICollection<CurrencyInfoResponse>>(new CurrencyInfoRequest());
    }
}
