using Abp.Core.AbpModularity.DataTransfers;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpDbConnectionOptions
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public AbpDbConnectionOptions()
        {
            ConnectionStrings = new ConnectionStrings();
        }
    }
}
