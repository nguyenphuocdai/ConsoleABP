using Abp.Core.AbpModularity.Interfaces;
using Castle.DynamicProxy;

namespace Abp.Core.AbpModularity.InterceptorRegistrar
{
    public class AbpAsyncDeterminationInterceptor<TInterceptor> : AsyncDeterminationInterceptor
        where TInterceptor : IAbpInterceptor
    {
        public AbpAsyncDeterminationInterceptor(TInterceptor abpInterceptor)
            : base(new CastleAsyncAbpInterceptorAdapter<TInterceptor>(abpInterceptor))
        {

        }
    }
}
