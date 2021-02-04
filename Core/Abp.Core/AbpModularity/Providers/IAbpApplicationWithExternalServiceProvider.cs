using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity.Providers
{
    public interface IAbpApplicationWithExternalServiceProvider : IAbpApplication
    {
        void Initialize([NotNull] IServiceProvider serviceProvider);
    }
}
