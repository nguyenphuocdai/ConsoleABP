using System;
using System.Diagnostics.CodeAnalysis;
using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.AbpModularity.Context
{
    public class ApplicationInitializationContext : IServiceProviderAccessor
    {
        public IServiceProvider ServiceProvider { get; set; }

        public ApplicationInitializationContext([NotNull] IServiceProvider serviceProvider)
        {
            Check.NotNull(serviceProvider, nameof(serviceProvider));

            ServiceProvider = serviceProvider;
        }
    }
}
