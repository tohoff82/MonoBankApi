using System.Threading.Tasks;
using MonoBankApi.Models.Requests;
using MonoBankApi.Models.Responses;

namespace MonoBankApi.Implements
{
    public class MonoPersonal : MonoClient, IMonoPersonal
    {
        public MonoPersonal(string token) : base(token) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ClientInfoResponse> ReturnClientInfo() =>
            await HttpGetAsync<ClientInfoResponse>(new ClientInfoRequest());
    }
}
