using System;
using System.Collections.Generic;
using System.Reflection;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAbpModuleDescriptor
    {
        Type Type { get; }

        Assembly Assembly { get; }

        IAbpModule Instance { get; }

        bool IsLoadedAsPlugIn { get; }

        IReadOnlyList<IAbpModuleDescriptor> Dependencies { get; }
    }
}
