using MonoBankApi.Implements;
using MonoBankApi.Services;
using MonoBankApi.Serviсes;

namespace MonoBankApi
{
    public class MonoBank
    {
        private readonly IIsoLoader isoLoader;

        public readonly IMonoPublic PublicService;
        public readonly IMonoPersonal PersonalService;

        public MonoBank(string token)
        {
            isoLoader = new IsoLoader();
            isoLoader.LoadData();

            PublicService = new MonoPublic();
            PersonalService = new MonoPersonal(token);
        }        
    }
}
