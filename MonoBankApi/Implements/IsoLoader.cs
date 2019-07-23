using MonoBankApi.Helper;
using MonoBankApi.Serviсes;

namespace MonoBankApi.Implements
{
    public class IsoLoader : IIsoLoader
    {
        public void LoadData()
        {
            Iso4217Codes.LoadXml();
        }
    }
}
