using Abp.Core.AbpModularity.Context;
using JetBrains.Annotations;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IModuleManager
    {
        void InitializeModules([NotNull] ApplicationInitializationContext context);

        void ShutdownModules([NotNull] ApplicationShutdownContext context);
    }
}
