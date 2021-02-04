using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IEventNameProvider
    {
        string GetName(Type eventType);
    }
}
