using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpSettingOptions
    {
        public ITypeList<ISettingDefinitionProvider> DefinitionProviders { get; }

        public ITypeList<ISettingValueProvider> ValueProviders { get; }

        public AbpSettingOptions()
        {
            DefinitionProviders = new TypeList<ISettingDefinitionProvider>();
            ValueProviders = new TypeList<ISettingValueProvider>();
        }
    }
}
