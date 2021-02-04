using Abp.Core.AbpModularity.Context;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAbpClaimsPrincipalContributor
    {
        Task ContributeAsync(AbpClaimsPrincipalContributorContext context);
    }
}
