using Abp.Core.AbpModularity.Converter;
using Abp.Core.AbpModularity.Factory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpSystemTextJsonSerializerOptionsSetup : IConfigureOptions<AbpSystemTextJsonSerializerOptions>
    {
        protected IServiceProvider ServiceProvider { get; }

        public AbpSystemTextJsonSerializerOptionsSetup(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public void Configure(AbpSystemTextJsonSerializerOptions options)
        {
            options.JsonSerializerOptions.Converters.Add(ServiceProvider.GetRequiredService<AbpDateTimeConverter>());
            options.JsonSerializerOptions.Converters.Add(ServiceProvider.GetRequiredService<AbpNullableDateTimeConverter>());

            options.JsonSerializerOptions.Converters.Add(new AbpStringToEnumFactory());
            options.JsonSerializerOptions.Converters.Add(new AbpStringToBooleanConverter());

            options.JsonSerializerOptions.Converters.Add(new ObjectToInferredTypesConverter());
            options.JsonSerializerOptions.Converters.Add(new AbpHasExtraPropertiesJsonConverterFactory());
        }
    }
}
