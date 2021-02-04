using System;

namespace Abp.EventBus.RabbitMQ.Interfaces
{
    public interface IRabbitMqSerializer
    {
        byte[] Serialize(object obj);

        object Deserialize(byte[] value, Type type);
    }
}
