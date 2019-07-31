using System;
using System.Text;
using Newtonsoft.Json;

namespace MonoBankApi.Implements.Requests
{
    public abstract class MonoRequest
    {
        protected object bodyObj;
        protected StringBuilder sb;

        public MonoRequest()
            => sb = new StringBuilder();

        public Uri Uri 
            => new Uri(sb.ToString(), UriKind.Relative);

        public string Body 
            => JsonConvert.SerializeObject(bodyObj);
    }
}
