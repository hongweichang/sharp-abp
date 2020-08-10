﻿using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Options;
using SharpAbp.Abp.CSRedisCore;
using Volo.Abp.DependencyInjection;

namespace SharpAbp.Abp.Caching
{
    [DisableConventionalRegistration]
    public class AbpRedisCache : CSRedisCache
    {
        public AbpRedisCache(IOptions<CSRedisCoreCacheOption> options, ICSRedisClientFactory cSRedisClientFactory) : base(cSRedisClientFactory.Get(options.Value.Name))
        {

        }
    }
}