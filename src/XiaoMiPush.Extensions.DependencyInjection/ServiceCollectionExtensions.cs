﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using XiaoMiPush.Abstraction;

namespace XiaoMiPush.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXiaoMiPush(this IServiceCollection services)
        {
            services.AddSingleton<AbstractXiaoMiPushLoggerFactory, AspnetCoreXiaoMiPushLoggerFactory>();
            services.AddSingleton<DefaultHttpClient>();
            services.AddTransient<IXiaoMiSender, SenderV3>();

            return services;
        }

    }
}
