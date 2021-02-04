using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IServiceProviderAccessor
    {
        IServiceProvider ServiceProvider { get; }
    }
}
