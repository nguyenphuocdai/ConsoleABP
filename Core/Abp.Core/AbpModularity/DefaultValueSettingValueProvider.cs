using Abp.Core.AbpModularity.DataTransfers;
using Abp.Core.AbpModularity.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity
{
    public class DefaultValueSettingValueProvider : SettingValueProvider
    {
        public const string ProviderName = "D";

        public override string Name => ProviderName;

        public DefaultValueSettingValueProvider(ISettingStore settingStore)
            : base(settingStore)
        {

        }

        public override Task<string> GetOrNullAsync(SettingDefinition setting)
        {
            return Task.FromResult(setting.DefaultValue);
        }

        public override Task<List<SettingValue>> GetAllAsync(SettingDefinition[] settings)
        {
            return Task.FromResult(settings.Select(x => new SettingValue(x.Name, x.DefaultValue)).ToList());
        }
    }
}
