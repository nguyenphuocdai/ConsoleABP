using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using System.Text.Json;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpSystemTextJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; }

        public ITypeList UnsupportedTypes { get; }

        public AbpSystemTextJsonSerializerOptions()
        {
            JsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true
            };

            UnsupportedTypes = new TypeList();
        }
    }
}
