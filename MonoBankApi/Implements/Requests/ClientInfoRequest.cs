namespace MonoBankApi.Implements.Requests
{
    class ClientInfoRequest : MonoRequest
    {
        public ClientInfoRequest() : base()
            => sb.Append("/personal/client-info");
    }
}
