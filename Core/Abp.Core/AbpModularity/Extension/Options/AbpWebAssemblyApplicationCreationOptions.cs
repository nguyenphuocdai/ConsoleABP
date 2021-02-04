
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpWebAssemblyApplicationCreationOptions
    {
        public WebAssemblyHostBuilder HostBuilder { get; }

        public AbpApplicationCreationOptions ApplicationCreationOptions { get; }

        public AbpWebAssemblyApplicationCreationOptions(
            WebAssemblyHostBuilder hostBuilder,
            AbpApplicationCreationOptions applicationCreationOptions)
        {
            HostBuilder = hostBuilder;
            ApplicationCreationOptions = applicationCreationOptions;
        }
    }
}
