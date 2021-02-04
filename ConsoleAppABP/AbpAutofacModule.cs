using Abp.Core.AbpModularity.Module;
using Abp.Core.Attributes;

namespace ConsoleAppABP
{
    [DependsOn(typeof(AbpCastleCoreModule))]
    public class AbpAutofacModule : AbpModule
    {

    }
}
