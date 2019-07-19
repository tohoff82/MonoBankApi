using System;
using Newtonsoft.Json;

namespace MonoBankApi.Implements.Requests
{
    public abstract class MonoRequest
    {
        protected object bodyObj;

        public Uri Uri => GetUri();
        protected abstract Uri GetUri();

        public string Body => JsonConvert.SerializeObject(bodyObj);
    }
}
