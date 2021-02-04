using Abp.Core.Attributes;

namespace Abp.Core.AbpModularity.Module
{
    [DependsOn(
        typeof(AbpLocalizationAbstractionsModule),
        typeof(AbpValidationAbstractionsModule)
    )]
    public class AbpObjectExtendingModule : AbpModule
    {

    }
}
