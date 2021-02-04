using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;

namespace Abp.Core.AbpModularity.DependencyInjection
{
    public class ObjectAccessor<T> : IObjectAccessor<T>
    {
        public T Value { get; set; }

        public ObjectAccessor()
        {

        }

        public ObjectAccessor([CanBeNull] T obj)
        {
            Value = obj;
        }
    }
}
