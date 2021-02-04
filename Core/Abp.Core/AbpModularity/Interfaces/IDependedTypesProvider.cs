using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IDependedTypesProvider
    {
        [NotNull]
        Type[] GetDependedTypes();
    }
}
