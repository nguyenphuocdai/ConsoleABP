using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;

namespace Abp.Core.AbpModularity
{
    public class AbpModuleDescriptor : IAbpModuleDescriptor
    {
        public Type Type { get; }

        public Assembly Assembly { get; }

        public IAbpModule Instance { get; }

        public bool IsLoadedAsPlugIn { get; }

        public IReadOnlyList<IAbpModuleDescriptor> Dependencies => _dependencies.ToImmutableList();
        private readonly List<IAbpModuleDescriptor> _dependencies;

        public AbpModuleDescriptor(
            [NotNull] Type type,
            [NotNull] IAbpModule instance,
            bool isLoadedAsPlugIn)
        {
            Check.NotNull(type, nameof(type));
            Check.NotNull(instance, nameof(instance));

            if (!type.GetTypeInfo().IsAssignableFrom(instance.GetType()))
            {
                throw new ArgumentException($"Given module instance ({instance.GetType().AssemblyQualifiedName}) is not an instance of given module type: {type.AssemblyQualifiedName}");
            }

            Type = type;
            Assembly = type.Assembly;
            Instance = instance;
            IsLoadedAsPlugIn = isLoadedAsPlugIn;

            _dependencies = new List<IAbpModuleDescriptor>();
        }

        public void AddDependency(IAbpModuleDescriptor descriptor)
        {
            _dependencies.AddIfNotContains(descriptor);
        }

        public override string ToString()
        {
            return $"[AbpModuleDescriptor {Type.FullName}]";
        }
    }
}
