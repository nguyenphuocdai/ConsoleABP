using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.AbpModularity.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Core.AbpModularity.Module
{
    public class AbpSecurityModule : AbpModule
    {
        public override void PostConfigureServices(ServiceConfigurationContext context)
        {
            AutoAddClaimsPrincipalContributors(context.Services);
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            context.Services.Configure<AbpStringEncryptionOptions>(options =>
            {
                var keySize = configuration["StringEncryption:KeySize"];
                if (!keySize.IsNullOrWhiteSpace())
                {
                    if (int.TryParse(keySize, out var intValue))
                    {
                        options.Keysize = intValue;
                    }
                }

                var defaultPassPhrase = configuration["StringEncryption:DefaultPassPhrase"];
                if (!defaultPassPhrase.IsNullOrWhiteSpace())
                {
                    options.DefaultPassPhrase = defaultPassPhrase;
                }

                var initVectorBytes = configuration["StringEncryption:InitVectorBytes"];
                if (!initVectorBytes.IsNullOrWhiteSpace())
                {
                    options.InitVectorBytes = Encoding.ASCII.GetBytes(initVectorBytes); ;
                }

                var defaultSalt = configuration["StringEncryption:DefaultSalt"];
                if (!defaultSalt.IsNullOrWhiteSpace())
                {
                    options.DefaultSalt = Encoding.ASCII.GetBytes(defaultSalt); ;
                }
            });
        }

        private static void AutoAddClaimsPrincipalContributors(IServiceCollection services)
        {
            var contributorTypes = new List<Type>();

            services.OnRegistred(context =>
            {
                if (typeof(IAbpClaimsPrincipalContributor).IsAssignableFrom(context.ImplementationType))
                {
                    contributorTypes.Add(context.ImplementationType);
                }
            });

            services.Configure<AbpClaimsPrincipalFactoryOptions>(options =>
            {
                options.Contributors.AddIfNotContains(contributorTypes);
            });
        }
    }
}
