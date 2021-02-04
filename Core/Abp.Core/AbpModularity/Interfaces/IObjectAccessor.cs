using JetBrains.Annotations;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IObjectAccessor<out T>
    {
        [CanBeNull]
        T Value { get; }
    }
}
