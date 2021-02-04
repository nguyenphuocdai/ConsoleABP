using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.Attributes;

namespace Abp.Core.AbpModularity.Module
{
    [DependsOn(
        typeof(AbpVirtualFileSystemModule),
        typeof(AbpSettingsModule),
        typeof(AbpLocalizationAbstractionsModule)
    )]
    public class AbpLocalizationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            AbpStringLocalizerFactory.Replace(context.Services);

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpLocalizationModule>("Volo.Abp", "Volo/Abp");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options
                    .Resources
                    .Add<DefaultResource>("en");

                options
                    .Resources
                    .Add<AbpLocalizationResource>("en")
                    .AddVirtualJson("/Localization/Resources/AbpLocalization");
            });
        }
    }
}
