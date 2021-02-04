using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using Abp.Core.Attributes;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Abp.Core.AbpModularity
{
    public class LocalizationResource
    {
        [NotNull]
        public Type ResourceType { get; }

        [NotNull]
        public string ResourceName => LocalizationResourceNameAttribute.GetName(ResourceType);

        [CanBeNull]
        public string DefaultCultureName { get; set; }

        [NotNull]
        public LocalizationResourceContributorList Contributors { get; }

        [NotNull]
        public List<Type> BaseResourceTypes { get; }

        public LocalizationResource(
            [NotNull] Type resourceType,
            [CanBeNull] string defaultCultureName = null,
            [CanBeNull] ILocalizationResourceContributor initialContributor = null)
        {
            ResourceType = Check.NotNull(resourceType, nameof(resourceType));
            DefaultCultureName = defaultCultureName;

            BaseResourceTypes = new List<Type>();
            Contributors = new LocalizationResourceContributorList();

            if (initialContributor != null)
            {
                Contributors.Add(initialContributor);
            }

            AddBaseResourceTypes();
        }

        protected virtual void AddBaseResourceTypes()
        {
            var descriptors = ResourceType
                .GetCustomAttributes(true)
                .OfType<IInheritedResourceTypesProvider>();

            foreach (var descriptor in descriptors)
            {
                foreach (var baseResourceType in descriptor.GetInheritedResourceTypes())
                {
                    BaseResourceTypes.AddIfNotContains(baseResourceType);
                }
            }
        }
    }
}
