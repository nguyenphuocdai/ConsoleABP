using Abo.EventBus.Interfaces;
using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abo.EventBus.EventBus.Distributed
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
