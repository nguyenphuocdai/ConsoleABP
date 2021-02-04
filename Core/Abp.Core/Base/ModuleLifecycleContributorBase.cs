using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.Interfaces;

namespace Abp.Core.Base
{
    public abstract class ModuleLifecycleContributorBase : IModuleLifecycleContributor
    {
        public virtual void Initialize(ApplicationInitializationContext context, IAbpModule module)
        {
        }

        public virtual void Shutdown(ApplicationShutdownContext context, IAbpModule module)
        {
        }
    }
}
