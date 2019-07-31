namespace MonoBankApi.Implements.Requests
{
    public class CurrencyInfoRequest : MonoRequest
    {
        public CurrencyInfoRequest() : base()
            => sb.Append("/bank/currency");
    }
}
