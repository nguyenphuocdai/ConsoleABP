using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.InterceptorRegistrar;

namespace Abp.Core.AbpModularity.Module
{
    public class AbpUnitOfWorkModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.OnRegistred(UnitOfWorkInterceptorRegistrar.RegisterIfNeeded);
        }
    }
}
