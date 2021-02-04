using JetBrains.Annotations;
using Microsoft.Extensions.Localization;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAbpStringLocalizerFactoryWithDefaultResourceSupport
    {
        [CanBeNull]
        IStringLocalizer CreateDefaultOrNull();
    }
}
