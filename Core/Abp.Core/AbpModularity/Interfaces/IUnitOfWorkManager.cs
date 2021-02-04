﻿using Abp.Core.AbpModularity.Extension.Options;
using JetBrains.Annotations;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IUnitOfWorkManager
    {
        [CanBeNull]
        IUnitOfWork Current { get; }

        [NotNull]
        IUnitOfWork Begin([NotNull] AbpUnitOfWorkOptions options, bool requiresNew = false);

        [NotNull]
        IUnitOfWork Reserve([NotNull] string reservationName, bool requiresNew = false);

        void BeginReserved([NotNull] string reservationName, [NotNull] AbpUnitOfWorkOptions options);

        bool TryBeginReserved([NotNull] string reservationName, [NotNull] AbpUnitOfWorkOptions options);
    }
}
