using System.Diagnostics.CodeAnalysis;
using Abp.Core.AbpModularity.Context;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IOnApplicationInitialization
    {
        void OnApplicationInitialization([NotNull] ApplicationInitializationContext context);
    }
}
