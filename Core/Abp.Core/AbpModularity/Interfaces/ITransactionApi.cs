using System;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ITransactionApi : IDisposable
    {
        Task CommitAsync();
    }
}
