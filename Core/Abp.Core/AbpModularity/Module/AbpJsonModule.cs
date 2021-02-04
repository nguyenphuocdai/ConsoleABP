using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Converter;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.AbpModularity.Providers;
using Abp.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Abp.Core.AbpModularity.Module
{
    [DependsOn(typeof(AbpTimingModule))]
    public class AbpJsonModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.TryAddEnumerable(ServiceDescriptor
                .Transient<IConfigureOptions<AbpSystemTextJsonSerializerOptions>, AbpSystemTextJsonSerializerOptionsSetup>());

            Configure<AbpJsonOptions>(options =>
            {
                options.Providers.Add<AbpNewtonsoftJsonSerializerProvider>();

                var abpJsonOptions = context.Services.ExecutePreConfiguredActions<AbpJsonOptions>();
                if (abpJsonOptions.UseHybridSerializer)
                {
                    options.Providers.Add<AbpSystemTextJsonSerializerProvider>();
                }
            });

            Configure<AbpNewtonsoftJsonSerializerOptions>(options =>
            {
                options.Converters.Add<AbpJsonIsoDateTimeConverter>();
            });
        }
    }
}
