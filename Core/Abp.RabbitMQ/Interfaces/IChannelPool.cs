using System;

namespace Abp.RabbitMQ.Interfaces
{
    public interface IChannelPool : IDisposable
    {
        IChannelAccessor Acquire(string channelName = null, string connectionName = null);
    }
}
