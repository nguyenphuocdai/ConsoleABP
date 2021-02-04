using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpLocalEventBusOptions
    {
        public ITypeList<IEventHandler> Handlers { get; }

        public AbpLocalEventBusOptions()
        {
            Handlers = new TypeList<IEventHandler>();
        }
    }
}
