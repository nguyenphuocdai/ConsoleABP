namespace Abp.Core.AbpModularity.Interfaces
{
    //TODO: Move to Volo.Abp.Data.ObjectExtending namespace at 4.0?

    public interface IHasExtraProperties
    {
        ExtraPropertyDictionary ExtraProperties { get; }
    }
}
