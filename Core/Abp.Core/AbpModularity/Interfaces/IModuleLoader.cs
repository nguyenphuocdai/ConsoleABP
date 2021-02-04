using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IModuleLoader
    {
        [NotNull]
        IAbpModuleDescriptor[] LoadModules(
            [NotNull] IServiceCollection services,
            [NotNull] Type startupModuleType,
            [NotNull] PlugInSourceList plugInSources
        );
    }
}
