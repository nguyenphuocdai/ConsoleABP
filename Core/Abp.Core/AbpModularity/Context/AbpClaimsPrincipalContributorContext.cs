using JetBrains.Annotations;
using System;
using System.Security.Claims;

namespace Abp.Core.AbpModularity.Context
{
    public class AbpClaimsPrincipalContributorContext
    {
        [NotNull]
        public ClaimsPrincipal ClaimsPrincipal { get; }

        [NotNull]
        public IServiceProvider ServiceProvider { get; }

        public AbpClaimsPrincipalContributorContext(
            [NotNull] ClaimsPrincipal claimsIdentity,
            [NotNull] IServiceProvider serviceProvider)
        {
            ClaimsPrincipal = claimsIdentity;
            ServiceProvider = serviceProvider;
        }
    }
}
