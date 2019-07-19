﻿using MonoBankApi.Implements;
using MonoBankApi.Services;

namespace MonoBankApi
{
    public class MonoApi
    {
        public readonly IMonoPublic PublicService;
        public readonly IMonoPersonal PersonalService;

        public MonoApi(string webhookUrl, string token)
        {
            PublicService = new MonoPublic();
            PersonalService = new MonoPersonal(token);
            PersonalService.SetWebHookAsync(webhookUrl);
        }        
    }
}