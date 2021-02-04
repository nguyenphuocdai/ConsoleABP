using Abp.Core.AbpModularity.Extension;
using System;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.DataTransfers
{
    [Serializable]
    public class ConnectionStrings : Dictionary<string, string>
    {
        public const string DefaultConnectionStringName = "Default";

        public string Default
        {
            get => this.GetOrDefault(DefaultConnectionStringName);
            set => this[DefaultConnectionStringName] = value;
        }
    }
}
