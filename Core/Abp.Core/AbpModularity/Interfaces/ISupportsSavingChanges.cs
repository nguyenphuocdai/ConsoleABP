using System.Threading;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ISupportsSavingChanges
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
