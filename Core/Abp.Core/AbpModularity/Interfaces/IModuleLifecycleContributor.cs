using Abp.Core.AbpModularity.Context;
using JetBrains.Annotations;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IModuleLifecycleContributor : ITransientDependency
    {
        void Initialize([NotNull] ApplicationInitializationContext context, [NotNull] IAbpModule module);

        void Shutdown([NotNull] ApplicationShutdownContext context, [NotNull] IAbpModule module);
    }
}
