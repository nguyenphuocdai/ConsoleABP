using Abp.Core.AbpModularity.Context;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IPostConfigureServices
    {
        void PostConfigureServices(ServiceConfigurationContext context);
    }
}
