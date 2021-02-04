using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Abp.Core.AbpModularity
{
    public class PlugInSourceList : List<IPlugInSource>
    {
        [NotNull]
        internal Type[] GetAllModules()
        {
            return this
                .SelectMany(pluginSource => pluginSource.GetModulesWithAllDependencies())
                .Distinct()
                .ToArray();
        }
    }
}
