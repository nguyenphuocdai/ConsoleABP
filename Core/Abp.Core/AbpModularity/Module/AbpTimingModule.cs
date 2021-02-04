using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.Attributes;

namespace Abp.Core.AbpModularity.Module
{
    [DependsOn(
        typeof(AbpLocalizationModule),
        typeof(AbpSettingsModule)
    )]
    public class AbpTimingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpTimingModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options
                    .Resources
                    .Add<AbpTimingResource>("en")
                    .AddVirtualJson("/Volo/Abp/Timing/Localization");
            });
        }
    }
}
