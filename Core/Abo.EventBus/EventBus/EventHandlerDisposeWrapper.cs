using Abo.EventBus.Interfaces;
using System;
using Abp.Core.AbpModularity.Interfaces;

namespace Abo.EventBus.EventBus
{
    public class EventHandlerDisposeWrapper : IEventHandlerDisposeWrapper
    {
        public IEventHandler EventHandler { get; }

        private readonly Action _disposeAction;

        public EventHandlerDisposeWrapper(IEventHandler eventHandler, Action disposeAction = null)
        {
            _disposeAction = disposeAction;
            EventHandler = eventHandler;
        }

        public void Dispose()
        {
            _disposeAction?.Invoke();
        }
    }
}
