using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface ICurrentTenant
    {
        bool IsAvailable { get; }

        [CanBeNull]
        Guid? Id { get; }

        [CanBeNull]
        string Name { get; }

        IDisposable Change(Guid? id, string name = null);
    }
}
