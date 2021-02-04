using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IOnServiceRegistredContext
    {
        ITypeList<IAbpInterceptor> Interceptors { get; }

        Type ImplementationType { get; }
    }
}
