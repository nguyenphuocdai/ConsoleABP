using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Module;
using Abp.Core.Attributes;
using Abp.EventBus.RabbitMQ.DataTransfer;
using Abp.EventBus.RabbitMQ.Module;

namespace ConsoleAppABP
{
    [DependsOn(
        typeof(AbpEventBusRabbitMqModule),
        typeof(AbpAutofacModule)
    )]
    public class App2Module : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpRabbitMqEventBusOptions>(options =>
            {
                options.ClientName = "TestApp2";
                options.ExchangeName = "TestMessages";
            });
        }
    }
}