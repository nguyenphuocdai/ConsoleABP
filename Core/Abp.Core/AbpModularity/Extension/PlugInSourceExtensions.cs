using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;
using System.Linq;

namespace Abp.Core.AbpModularity.Extension
{
    public static class PlugInSourceExtensions
    {
        [NotNull]
        public static Type[] GetModulesWithAllDependencies([NotNull] this IPlugInSource plugInSource)
        {
            Check.NotNull(plugInSource, nameof(plugInSource));

            return plugInSource
                .GetModules()
                .SelectMany(AbpModuleHelper.FindAllModuleTypes)
                .Distinct()
                .ToArray();
        }
    }
}
