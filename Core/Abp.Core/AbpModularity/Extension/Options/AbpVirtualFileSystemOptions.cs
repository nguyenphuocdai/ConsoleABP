namespace Abp.Core.AbpModularity.Extension.Options
{
    public class AbpVirtualFileSystemOptions
    {
        public VirtualFileSetList FileSets { get; }

        public AbpVirtualFileSystemOptions()
        {
            FileSets = new VirtualFileSetList();
        }
    }
}
