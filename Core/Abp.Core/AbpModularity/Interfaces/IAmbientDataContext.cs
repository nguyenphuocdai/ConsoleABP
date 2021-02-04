namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IAmbientDataContext
    {
        void SetData(string key, object value);

        object GetData(string key);
    }
}
