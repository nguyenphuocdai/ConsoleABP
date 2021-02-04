using Abp.Core.AbpModularity.Extension;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Abp.Core.AbpModularity.Helper
{
    public static class JsonSerializerOptionsHelper
    {
        public static JsonSerializerOptions Create(JsonSerializerOptions baseOptions, JsonConverter removeConverter, params JsonConverter[] addConverters)
        {
            return Create(baseOptions, x => x == removeConverter, addConverters);
        }

        public static JsonSerializerOptions Create(JsonSerializerOptions baseOptions, Func<JsonConverter, bool> removeConverterPredicate, params JsonConverter[] addConverters)
        {
            var options = new JsonSerializerOptions(baseOptions);
            options.Converters.RemoveAll(removeConverterPredicate);
            options.Converters.AddIfNotContains(addConverters);
            return options;
        }
    }
}
