using System;
using System.Diagnostics.CodeAnalysis;
using Abp.Core.AbpModularity.Helper;

namespace Abp.Core.AbpModularity.Context
{
    public class ApplicationShutdownContext
    {
        public IServiceProvider ServiceProvider { get; }

        public ApplicationShutdownContext([NotNull] IServiceProvider serviceProvider)
        {
            Check.NotNull(serviceProvider, nameof(serviceProvider));

            ServiceProvider = serviceProvider;
        }
    }
}
