using RabbitMQ.Client;
using System;

namespace Abp.EventBus.RabbitMQ.Interfaces
{
    public interface IConnectionPool : IDisposable
    {
        IConnection Get(string connectionName = null);
    }
}
