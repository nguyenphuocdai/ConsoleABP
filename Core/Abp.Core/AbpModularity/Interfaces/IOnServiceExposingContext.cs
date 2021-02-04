using System;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IOnServiceExposingContext
    {
        Type ImplementationType { get; }

        List<Type> ExposedTypes { get; }
    }
}
