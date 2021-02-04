namespace Abp.RabbitMQ.DataTransfers
{
    public class AbpRabbitMqOptions
    {
        public RabbitMqConnections Connections { get; }

        public AbpRabbitMqOptions()
        {
            Connections = new RabbitMqConnections();
        }
    }
}
