namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAbpApplicationWithInternalServiceProvider : IAbpApplication
    {
        void Initialize();
    }
}
