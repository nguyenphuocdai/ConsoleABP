using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.InterceptorRegistrar;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.Core.AbpModularity.Module
{
    public class AbpCastleCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient(typeof(AbpAsyncDeterminationInterceptor<>));
        }
    }
}
