using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using Newtonsoft.Json;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpNewtonsoftJsonSerializerOptions
    {
        public ITypeList<JsonConverter> Converters { get; }

        public AbpNewtonsoftJsonSerializerOptions()
        {
            Converters = new TypeList<JsonConverter>();
        }
    }
}
