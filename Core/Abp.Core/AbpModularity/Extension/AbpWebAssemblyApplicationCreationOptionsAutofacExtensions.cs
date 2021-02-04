using Abp.Core.AbpModularity.Extension.Options;
using Autofac;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Abp.Core.AbpModularity.Extension
{
    public static class AbpWebAssemblyApplicationCreationOptionsAutofacExtensions
    {
        public static void UseAutofac(
            [NotNull] this AbpWebAssemblyApplicationCreationOptions options,
            [CanBeNull] Action<ContainerBuilder> configure = null)
        {
            options.HostBuilder.Services.AddAutofacServiceProviderFactory();
            options.HostBuilder.ConfigureContainer(
                options.HostBuilder.Services.GetSingletonInstance<IServiceProviderFactory<ContainerBuilder>>(),
                configure
            );
        }
    }
}
