using RabbitMQ.Client;
using System;

namespace Abp.RabbitMQ.Interfaces
{
    public interface IConnectionPool : IDisposable
    {
        IConnection Get(string connectionName = null);
    }
}
