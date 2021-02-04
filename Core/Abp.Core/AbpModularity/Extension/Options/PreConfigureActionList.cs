using System;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity.Extension.Options
{
    public class PreConfigureActionList<TOptions> : List<Action<TOptions>>
    {
        /// <exception cref="T:System.Exception">A delegate callback throws an exception.</exception>
        public void Configure(TOptions options)
        {
            foreach (var action in this)
            {
                action(options);
            }
        }
    }
}
