using Abp.Core.AbpModularity.Interfaces;
using System;
using System.Collections.Generic;

namespace Abp.Core.AbpModularity
{
    public class ServiceRegistrationActionList : List<Action<IOnServiceRegistredContext>>
    {

    }
}
