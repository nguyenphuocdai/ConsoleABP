using Abp.Core.AbpModularity.Interfaces;
using System.Threading;

namespace Abp.Core.AbpModularity.Providers
{
    public class NullCancellationTokenProvider : ICancellationTokenProvider
    {
        public static NullCancellationTokenProvider Instance { get; } = new NullCancellationTokenProvider();

        public CancellationToken Token { get; } = CancellationToken.None;

        private NullCancellationTokenProvider()
        {

        }
    }
}
