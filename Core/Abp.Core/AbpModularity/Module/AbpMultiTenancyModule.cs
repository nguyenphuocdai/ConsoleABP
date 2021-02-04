using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.Attributes;

namespace Abp.Core.AbpModularity.Module
{
    //TODO: Create a Volo.Abp.MultiTenancy.Abstractions package?

    [DependsOn(
        typeof(AbpDataModule),
        typeof(AbpSecurityModule),
        typeof(AbpEventBusAbstractionsModule)
    )]
    public class AbpMultiTenancyModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            Configure<AbpDefaultTenantStoreOptions>(configuration);
        }
    }
}
