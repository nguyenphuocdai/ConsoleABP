using Abp.Core.AbpModularity.Context;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ILocalizationResourceContributor
    {
        void Initialize(LocalizationResourceInitializationContext context);

        LocalizedString GetOrNull(string cultureName, string name);

        void Fill(string cultureName, Dictionary<string, LocalizedString> dictionary);
    }
}
