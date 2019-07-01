using System;
using System.Threading.Tasks;
using MonoBankApi.Models.Responses;

namespace MonoBankApi
{
    public interface IMonoPersonal : IDisposable
    {
        Task<ClientInfoResponse> ReturnClientInfo();
    }
}
