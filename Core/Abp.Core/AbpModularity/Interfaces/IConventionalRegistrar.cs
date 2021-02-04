using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Abp.Core.AbpModularity.Interfaces
{
    public interface IConventionalRegistrar
    {
        void AddAssembly(IServiceCollection services, Assembly assembly);

        void AddTypes(IServiceCollection services, params Type[] types);

        void AddType(IServiceCollection services, Type type);
    }
}
