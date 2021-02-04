using Abp.Core.AbpModularity.DataTransfers;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ISettingDefinitionContext
    {
        SettingDefinition GetOrNull(string name);

        IReadOnlyList<SettingDefinition> GetAll();

        void Add(params SettingDefinition[] definitions);
    }
}
