using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IStringLocalizerSupportsInheritance
    {
        IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures, bool includeBaseLocalizers);
    }
}
