using Abp.Core.AbpModularity.Helper;
using JetBrains.Annotations;
using Microsoft.Extensions.FileProviders;

namespace Abp.Core.AbpModularity
{
    public class VirtualFileSetInfo
    {
        public IFileProvider FileProvider { get; }

        public VirtualFileSetInfo([NotNull] IFileProvider fileProvider)
        {
            FileProvider = Check.NotNull(fileProvider, nameof(fileProvider));
        }
    }
}
