using Abp.Core.AbpModularity.Helper;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpApplicationCreationOptions
    {
        [NotNull]
        public IServiceCollection Services { get; }

        [NotNull]
        public PlugInSourceList PlugInSources { get; }

        /// <summary>
        /// The options in this property only take effect when IConfiguration not registered.
        /// </summary>
        [NotNull]
        public AbpConfigurationBuilderOptions Configuration { get; }

        public AbpApplicationCreationOptions([NotNull] IServiceCollection services)
        {
            Services = Check.NotNull(services, nameof(services));
            PlugInSources = new PlugInSourceList();
            Configuration = new AbpConfigurationBuilderOptions();
        }
    }
}
