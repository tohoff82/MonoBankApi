using System;
using Microsoft.Extensions.DependencyInjection;
using MonoBankApi.Implements;
using MonoBankApi.Services;

namespace MonoBankApi
{
    public static class MonoBankConnector
    {
        private static readonly string _authHeader   = "X-Token";
        private static readonly string _baseEndpoint = "https://api.monobank.ua";

        public static void AddMonoApi(this IServiceCollection services)
        {
            services.AddHttpClient<MonoApiContext>(httpClient =>
            {
                httpClient.BaseAddress = new Uri(_baseEndpoint);
            }).SetHandlerLifetime(TimeSpan.FromMinutes(3));

            services.AddTransient<IMonoPublic>(x => new MonoPublic(x.GetService<MonoApiContext>()));
        }

        public static void AddMonoApi(this IServiceCollection services, string apiToken)
        {
            services.AddHttpClient<MonoApiContext>(httpClient =>
            {
                httpClient.BaseAddress = new Uri(_baseEndpoint);
                httpClient.DefaultRequestHeaders.Add(_authHeader, apiToken);
            }).SetHandlerLifetime(TimeSpan.FromMinutes(3));

            services.AddTransient<IMonoPublic>(x   => new MonoPublic(x.GetService<MonoApiContext>()));
            services.AddTransient<IMonoPersonal>(x => new MonoPersonal(x.GetService<MonoApiContext>()));
        }
    }
}
