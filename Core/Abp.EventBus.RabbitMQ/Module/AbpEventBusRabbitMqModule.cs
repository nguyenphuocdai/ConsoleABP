using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Module;
using Abp.Core.Attributes;
using Abp.EventBus.RabbitMQ.DataTransfer;
using Abp.EventBus.RabbitMQ.EventBus;
using Abp.RabbitMQ.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.EventBus.RabbitMQ.Module
{
    [DependsOn(typeof(AbpEventBusModule), typeof(AbpRabbitMqModule))]
    public class AbpEventBusRabbitMqModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AbpRabbitMqEventBusOptions>(configuration.GetSection("RabbitMQ:EventBus"));
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context
                .ServiceProvider
                .GetRequiredService<RabbitMqDistributedEventBus>()
                .Initialize();
        }
    }
}
