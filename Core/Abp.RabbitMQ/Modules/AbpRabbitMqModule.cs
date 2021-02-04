using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Module;
using Abp.Core.Attributes;
using Abp.RabbitMQ.DataTransfers;
using Abp.RabbitMQ.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.RabbitMQ.Modules
{
    [DependsOn(
        typeof(AbpJsonModule),
        typeof(AbpThreadingModule)
    )]
    public class AbpRabbitMqModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            Configure<AbpRabbitMqOptions>(configuration.GetSection("RabbitMQ"));
            Configure<AbpRabbitMqOptions>(options =>
            {
                foreach (var connectionFactory in options.Connections.Values)
                {
                    connectionFactory.DispatchConsumersAsync = true;
                }
            });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            context.ServiceProvider
                .GetRequiredService<IChannelPool>()
                .Dispose();

            context.ServiceProvider
                .GetRequiredService<IConnectionPool>()
                .Dispose();
        }
    }
}
