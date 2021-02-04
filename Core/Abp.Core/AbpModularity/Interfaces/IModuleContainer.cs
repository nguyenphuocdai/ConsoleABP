using System.Collections.Generic;
using JetBrains.Annotations;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IModuleContainer
    {
        [NotNull]
        IReadOnlyList<IAbpModuleDescriptor> Modules { get; }
    }
}
