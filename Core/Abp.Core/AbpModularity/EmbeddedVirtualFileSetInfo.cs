using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace Abp.Core.AbpModularity
{
    public class EmbeddedVirtualFileSetInfo : VirtualFileSetInfo
    {
        public Assembly Assembly { get; }

        public string BaseFolder { get; }

        public EmbeddedVirtualFileSetInfo(
            IFileProvider fileProvider,
            Assembly assembly,
            string baseFolder = null)
            : base(fileProvider)
        {
            Assembly = assembly;
            BaseFolder = baseFolder;
        }
    }
}
