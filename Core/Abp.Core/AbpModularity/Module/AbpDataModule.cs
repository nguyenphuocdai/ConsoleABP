using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.AbpModularity.Interfaces;
using Abp.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Module
{
    [DependsOn(
        typeof(AbpObjectExtendingModule),
        typeof(AbpUnitOfWorkModule)
    )]
    public class AbpDataModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AutoAddDataSeedContributors(context.Services);
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AbpDbConnectionOptions>(configuration);

            context.Services.AddSingleton(typeof(IDataFilter<>), typeof(DataFilter<>));
        }

        private static void AutoAddDataSeedContributors(IServiceCollection services)
        {
            var contributors = new List<Type>();

            services.OnRegistred(context =>
            {
                if (typeof(IDataSeedContributor).IsAssignableFrom(context.ImplementationType))
                {
                    contributors.Add(context.ImplementationType);
                }
            });

            services.Configure<AbpDataSeedOptions>(options =>
            {
                options.Contributors.AddIfNotContains(contributors);
            });
        }
    }
}
