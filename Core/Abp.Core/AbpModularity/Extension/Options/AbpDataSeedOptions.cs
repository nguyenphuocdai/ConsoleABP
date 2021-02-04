namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpDataSeedOptions
    {
        public DataSeedContributorList Contributors { get; }

        public AbpDataSeedOptions()
        {
            Contributors = new DataSeedContributorList();
        }
    }
}
