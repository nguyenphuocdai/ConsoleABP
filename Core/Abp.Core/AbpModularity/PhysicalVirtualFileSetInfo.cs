using Abp.Core.AbpModularity.Helper;
using JetBrains.Annotations;
using Microsoft.Extensions.FileProviders;

namespace Abp.Core.AbpModularity
{
    public class PhysicalVirtualFileSetInfo : VirtualFileSetInfo
    {
        public string Root { get; }

        public PhysicalVirtualFileSetInfo(
            [NotNull] IFileProvider fileProvider,
            [NotNull] string root
        )
            : base(fileProvider)
        {
            Root = Check.NotNullOrWhiteSpace(root, nameof(root));
        }
    }
}
