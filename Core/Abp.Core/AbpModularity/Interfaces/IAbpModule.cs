using Abp.Core.AbpModularity.Context;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAbpModule
    {
        void ConfigureServices(ServiceConfigurationContext context);
    }
}
