using System.Diagnostics.CodeAnalysis;
using Abp.Core.AbpModularity.Context;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IOnApplicationShutdown
    {
        void OnApplicationShutdown([NotNull] ApplicationShutdownContext context);
    }
}
