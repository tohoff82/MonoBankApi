using MonoBankApi.Implements;
using MonoBankApi.Services;

namespace MonoBankApi
{
    public class MonoBank
    {
        public readonly IMonoPublic PublicService;
        public readonly IMonoPersonal PersonalService;

        public MonoBank(string token)
        {
            PublicService = new MonoPublic();
            PersonalService = new MonoPersonal(token);
        }        
    }
}
