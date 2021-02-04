using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;

namespace Abp.Core.AbpModularity.InterceptorRegistrar
{
    public class UnitOfWorkEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the unit of work related to this event.
        /// </summary>
        public IUnitOfWork UnitOfWork { get; }

        public UnitOfWorkEventArgs([NotNull] IUnitOfWork unitOfWork)
        {
            Check.NotNull(unitOfWork, nameof(unitOfWork));

            UnitOfWork = unitOfWork;
        }
    }
}
