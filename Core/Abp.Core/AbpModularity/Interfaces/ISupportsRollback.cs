using System.Threading;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ISupportsRollback
    {
        Task RollbackAsync(CancellationToken cancellationToken);
    }
}
