using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using Microsoft.Extensions.Options;
using System;

namespace Abp.Core.AbpModularity
{
    public class AbpSystemTextJsonUnsupportedTypeMatcher : ITransientDependency
    {
        protected AbpSystemTextJsonSerializerOptions Options { get; }

        public AbpSystemTextJsonUnsupportedTypeMatcher(IOptions<AbpSystemTextJsonSerializerOptions> options)
        {
            Options = options.Value;
        }

        public virtual bool Match([CanBeNull] Type type)
        {
            return Options.UnsupportedTypes.Contains(type);
        }
    }
}
