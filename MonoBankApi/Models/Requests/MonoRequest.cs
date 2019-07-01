namespace MonoBankApi.Models.Requests
{
    public abstract class MonoRequest
    {
        public string Url => GetUrl();
        protected abstract string GetUrl();
    }
}
