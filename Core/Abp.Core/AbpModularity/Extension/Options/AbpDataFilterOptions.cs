using Abp.Core.AbpModularity.DataTransfers;
using System;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpDataFilterOptions
    {
        public Dictionary<Type, DataFilterState> DefaultStates { get; }

        public AbpDataFilterOptions()
        {
            DefaultStates = new Dictionary<Type, DataFilterState>();
        }
    }
}
