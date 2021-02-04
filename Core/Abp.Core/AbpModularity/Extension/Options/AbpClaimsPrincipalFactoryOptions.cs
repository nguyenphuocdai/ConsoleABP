using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpClaimsPrincipalFactoryOptions
    {
        public ITypeList<IAbpClaimsPrincipalContributor> Contributors { get; }

        public AbpClaimsPrincipalFactoryOptions()
        {
            Contributors = new TypeList<IAbpClaimsPrincipalContributor>();
        }
    }
}
