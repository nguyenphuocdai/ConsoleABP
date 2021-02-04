using Microsoft.Extensions.Localization;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ILocalizableString
    {
        LocalizedString Localize(IStringLocalizerFactory stringLocalizerFactory);
    }
}
