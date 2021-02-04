using Abp.Core.AbpModularity.DataTransfers;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpDefaultTenantStoreOptions
    {
        public TenantConfiguration[] Tenants { get; set; }

        public AbpDefaultTenantStoreOptions()
        {
            Tenants = new TenantConfiguration[0];
        }
    }
}
