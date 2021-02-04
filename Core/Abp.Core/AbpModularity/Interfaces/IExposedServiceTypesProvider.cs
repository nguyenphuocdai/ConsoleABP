using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IExposedServiceTypesProvider
    {
        Type[] GetExposedServiceTypes(Type targetType);
    }
}
