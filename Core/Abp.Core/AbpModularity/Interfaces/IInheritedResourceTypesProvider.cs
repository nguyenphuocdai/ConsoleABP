using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IInheritedResourceTypesProvider
    {
        [NotNull]
        Type[] GetInheritedResourceTypes();
    }
}
