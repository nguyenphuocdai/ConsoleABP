using Microsoft.Extensions.DependencyInjection;
using System;

namespace Abp.Core.Attributes
{
    public sealed class DependencyAttribute : Attribute
    {
        public ServiceLifetime? Lifetime { get; set; }

        public bool TryRegister { get; set; }

        public bool ReplaceServices { get; set; }

        public DependencyAttribute()
        {
        }

        public DependencyAttribute(ServiceLifetime lifetime)
        {
            Lifetime = lifetime;
        }
    }
}
