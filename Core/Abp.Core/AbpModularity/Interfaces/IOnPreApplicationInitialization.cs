using System.Diagnostics.CodeAnalysis;
using Abp.Core.AbpModularity.Context;

namespace Abp.Core.AbpModularity.Interfaces
{
    interface IOnPreApplicationInitialization
    {
        void OnPreApplicationInitialization([NotNull] ApplicationInitializationContext context);
    }
}
