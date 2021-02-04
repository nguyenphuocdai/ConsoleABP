using Abp.Core.AbpModularity.Interfaces;
using Microsoft.Extensions.FileProviders;
using System;

namespace Abp.Core.AbpModularity
{
    public class JsonVirtualFileLocalizationResourceContributor : VirtualFileLocalizationResourceContributorBase
    {
        public JsonVirtualFileLocalizationResourceContributor(string virtualPath)
            : base(virtualPath)
        {

        }

        protected override bool CanParseFile(IFileInfo file)
        {
            return file.Name.EndsWith(".json", StringComparison.OrdinalIgnoreCase);
        }

        protected override ILocalizationDictionary CreateDictionaryFromFileContent(string jsonString)
        {
            return JsonLocalizationDictionaryBuilder.BuildFromJsonString(jsonString);
        }
    }
}
