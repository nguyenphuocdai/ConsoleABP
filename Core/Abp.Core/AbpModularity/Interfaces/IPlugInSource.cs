using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IPlugInSource
    {
        [NotNull]
        Type[] GetModules();
    }
}
