using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpModuleLifecycleOptions
    {
        public ITypeList<IModuleLifecycleContributor> Contributors { get; }

        public AbpModuleLifecycleOptions()
        {
            Contributors = new TypeList<IModuleLifecycleContributor>();
        }
    }
}
