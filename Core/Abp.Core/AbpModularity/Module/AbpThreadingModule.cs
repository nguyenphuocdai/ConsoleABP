using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Interfaces;
using Abp.Core.AbpModularity.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.Core.AbpModularity.Module
{
    public class AbpThreadingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<ICancellationTokenProvider>(NullCancellationTokenProvider.Instance);
            context.Services.AddSingleton(typeof(IAmbientScopeProvider<>), typeof(AmbientDataContextAmbientScopeProvider<>));
        }
    }
}
