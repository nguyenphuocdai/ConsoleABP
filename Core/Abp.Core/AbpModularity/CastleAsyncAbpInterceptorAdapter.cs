using Abp.Core.AbpModularity.Interfaces;
using Abp.Core.Contributor;
using Castle.DynamicProxy;
using System;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity
{
    public class CastleAsyncAbpInterceptorAdapter<TInterceptor> : AsyncInterceptorBase
        where TInterceptor : IAbpInterceptor
    {
        private readonly TInterceptor _abpInterceptor;

        public CastleAsyncAbpInterceptorAdapter(TInterceptor abpInterceptor)
        {
            _abpInterceptor = abpInterceptor;
        }

        protected override async Task InterceptAsync(IInvocation invocation, IInvocationProceedInfo proceedInfo, Func<IInvocation, IInvocationProceedInfo, Task> proceed)
        {
            await _abpInterceptor.InterceptAsync(
                new CastleAbpMethodInvocationAdapter(invocation, proceedInfo, proceed)
            );
        }

        protected override async Task<TResult> InterceptAsync<TResult>(IInvocation invocation, IInvocationProceedInfo proceedInfo, Func<IInvocation, IInvocationProceedInfo, Task<TResult>> proceed)
        {
            var adapter = new CastleAbpMethodInvocationAdapterWithReturnValue<TResult>(invocation, proceedInfo, proceed);

            await _abpInterceptor.InterceptAsync(
                adapter
            );

            return (TResult)adapter.ReturnValue;
        }
    }
}
