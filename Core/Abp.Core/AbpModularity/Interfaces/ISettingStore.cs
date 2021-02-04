using Abp.Core.AbpModularity.DataTransfers;
using JetBrains.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ISettingStore
    {
        Task<string> GetOrNullAsync(
            [NotNull] string name,
            [CanBeNull] string providerName,
            [CanBeNull] string providerKey
        );

        Task<List<SettingValue>> GetAllAsync(
            [NotNull] string[] names,
            [CanBeNull] string providerName,
            [CanBeNull] string providerKey
        );
    }
}
