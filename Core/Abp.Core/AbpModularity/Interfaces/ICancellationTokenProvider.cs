using System.Threading;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ICancellationTokenProvider
    {
        CancellationToken Token { get; }
    }
}
