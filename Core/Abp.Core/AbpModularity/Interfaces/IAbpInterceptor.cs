using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAbpInterceptor
    {
        Task InterceptAsync(IAbpMethodInvocation invocation);
    }
}
