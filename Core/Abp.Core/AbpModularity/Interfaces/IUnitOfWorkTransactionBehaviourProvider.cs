namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IUnitOfWorkTransactionBehaviourProvider
    {
        bool? IsTransactional { get; }
    }
}
