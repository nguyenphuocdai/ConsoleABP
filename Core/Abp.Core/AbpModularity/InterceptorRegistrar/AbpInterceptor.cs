using Abp.Core.AbpModularity.Interfaces;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.InterceptorRegistrar
{
    public abstract class AbpInterceptor : IAbpInterceptor
    {
        public abstract Task InterceptAsync(IAbpMethodInvocation invocation);
    }
}
