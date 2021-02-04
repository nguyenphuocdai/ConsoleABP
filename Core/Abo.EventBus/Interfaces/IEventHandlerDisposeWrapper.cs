using System;
using Abp.Core.AbpModularity.Interfaces;

namespace Abo.EventBus.Interfaces
{
    public interface IEventHandlerDisposeWrapper : IDisposable
    {
        IEventHandler EventHandler { get; }
    }
}
