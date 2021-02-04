using Abp.Core.AbpModularity.Extension.Options;
using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using Abp.Core.Attributes;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.InterceptorRegistrar
{
    public class UnitOfWorkInterceptor : AbpInterceptor, ITransientDependency
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public UnitOfWorkInterceptor(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public override async Task InterceptAsync(IAbpMethodInvocation invocation)
        {
            if (!UnitOfWorkHelper.IsUnitOfWorkMethod(invocation.Method, out var unitOfWorkAttribute))
            {
                await invocation.ProceedAsync();
                return;
            }

            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var options = CreateOptions(scope.ServiceProvider, invocation, unitOfWorkAttribute);

                var unitOfWorkManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

                //Trying to begin a reserved UOW by AbpUnitOfWorkMiddleware
                if (unitOfWorkManager.TryBeginReserved(UnitOfWork.UnitOfWorkReservationName, options))
                {
                    await invocation.ProceedAsync();
                    return;
                }

                using (var uow = unitOfWorkManager.Begin(options))
                {
                    await invocation.ProceedAsync();
                    await uow.CompleteAsync();
                }
            }
        }

        private AbpUnitOfWorkOptions CreateOptions(IServiceProvider serviceProvider, IAbpMethodInvocation invocation, [CanBeNull] UnitOfWorkAttribute unitOfWorkAttribute)
        {
            var options = new AbpUnitOfWorkOptions();

            unitOfWorkAttribute?.SetOptions(options);

            if (unitOfWorkAttribute?.IsTransactional == null)
            {
                var defaultOptions = serviceProvider.GetRequiredService<IOptions<AbpUnitOfWorkDefaultOptions>>().Value;
                options.IsTransactional = defaultOptions.CalculateIsTransactional(
                    autoValue: serviceProvider.GetRequiredService<IUnitOfWorkTransactionBehaviourProvider>().IsTransactional
                               ?? !invocation.Method.Name.StartsWith("Get", StringComparison.InvariantCultureIgnoreCase)
                );
            }

            return options;
        }
    }
}
