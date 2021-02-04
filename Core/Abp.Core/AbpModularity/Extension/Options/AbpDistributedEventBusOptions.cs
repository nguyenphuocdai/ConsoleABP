using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpDistributedEventBusOptions
    {
        public ITypeList<IEventHandler> Handlers { get; }

        public AbpDistributedEventBusOptions()
        {
            Handlers = new TypeList<IEventHandler>();
        }
    }
}
