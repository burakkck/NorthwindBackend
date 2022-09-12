using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCuttingConcers.Caching;
using Core.CrossCuttingConcers.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolves {
    public class CoreModule : ICoreModule {
        public void Load(IServiceCollection services) {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();

        }
    }
}
