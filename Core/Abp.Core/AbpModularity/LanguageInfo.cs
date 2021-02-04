using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity
{
    [Serializable]
    public class LanguageInfo : ILanguageInfo
    {
        [NotNull]
        public virtual string CultureName { get; protected set; }

        [NotNull]
        public virtual string UiCultureName { get; protected set; }

        [NotNull]
        public virtual string DisplayName { get; protected set; }

        [CanBeNull]
        public virtual string FlagIcon { get; set; }

        protected LanguageInfo()
        {

        }

        public LanguageInfo(
            string cultureName,
            string uiCultureName = null,
            string displayName = null,
            string flagIcon = null)
        {
            ChangeCultureInternal(cultureName, uiCultureName, displayName);
            FlagIcon = flagIcon;
        }

        public virtual void ChangeCulture(string cultureName, string uiCultureName = null, string displayName = null)
        {
            ChangeCultureInternal(cultureName, uiCultureName, displayName);
        }

        private void ChangeCultureInternal(string cultureName, string uiCultureName, string displayName)
        {
            CultureName = Check.NotNullOrWhiteSpace(cultureName, nameof(cultureName));

            UiCultureName = !uiCultureName.IsNullOrWhiteSpace()
                ? uiCultureName
                : cultureName;

            DisplayName = !displayName.IsNullOrWhiteSpace()
                ? displayName
                : cultureName;
        }
    }
}
