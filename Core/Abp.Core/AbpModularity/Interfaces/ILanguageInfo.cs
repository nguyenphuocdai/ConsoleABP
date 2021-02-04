﻿namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ILanguageInfo
    {
        string CultureName { get; }

        string UiCultureName { get; }

        string DisplayName { get; }

        string FlagIcon { get; }
    }
}
