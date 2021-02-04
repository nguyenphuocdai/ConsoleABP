using Abp.Core.AbpModularity.DataTransfers;
using JetBrains.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ISettingValueProvider
    {
        string Name { get; }

        Task<string> GetOrNullAsync([NotNull] SettingDefinition setting);

        Task<List<SettingValue>> GetAllAsync([NotNull] SettingDefinition[] settings);
    }
}
