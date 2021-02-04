﻿
using Abp.Core.AbpModularity.Context;
using Abp.Core.AbpModularity.InterceptorRegistrar;
using Abp.Core.AbpModularity.Interfaces;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Abp.Core.AbpModularity.Extension
{
    public static class AbpRegistrationBuilderExtensions
    {
        public static IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> ConfigureAbpConventions<TLimit, TActivatorData, TRegistrationStyle>(
                this IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registrationBuilder,
                IModuleContainer moduleContainer,
                ServiceRegistrationActionList registrationActionList)
            where TActivatorData : ReflectionActivatorData
        {
            var serviceType = registrationBuilder.RegistrationData.Services.OfType<IServiceWithType>().FirstOrDefault()?.ServiceType;
            if (serviceType == null)
            {
                return registrationBuilder;
            }

            var implementationType = registrationBuilder.ActivatorData.ImplementationType;
            if (implementationType == null)
            {
                return registrationBuilder;
            }

            registrationBuilder = registrationBuilder.EnablePropertyInjection(moduleContainer, implementationType);
            registrationBuilder = registrationBuilder.InvokeRegistrationActions(registrationActionList, serviceType, implementationType);

            return registrationBuilder;
        }

        private static IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InvokeRegistrationActions<TLimit, TActivatorData, TRegistrationStyle>(this IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registrationBuilder, ServiceRegistrationActionList registrationActionList, Type serviceType, Type implementationType)
            where TActivatorData : ReflectionActivatorData
        {
            var serviceRegistredArgs = new OnServiceRegistredContext(serviceType, implementationType);

            foreach (var registrationAction in registrationActionList)
            {
                registrationAction.Invoke(serviceRegistredArgs);
            }

            if (serviceRegistredArgs.Interceptors.Any())
            {
                registrationBuilder = registrationBuilder.AddInterceptors(
                    serviceType,
                    serviceRegistredArgs.Interceptors
                );
            }

            return registrationBuilder;
        }

        private static IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> EnablePropertyInjection<TLimit, TActivatorData, TRegistrationStyle>(
                this IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registrationBuilder,
                IModuleContainer moduleContainer,
                Type implementationType)
            where TActivatorData : ReflectionActivatorData
        {
            //Enable Property Injection only for types in an assembly containing an AbpModule
            if (moduleContainer.Modules.Any(m => m.Assembly == implementationType.Assembly))
            {
                registrationBuilder = registrationBuilder.PropertiesAutowired();
            }

            return registrationBuilder;
        }

        private static IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> AddInterceptors<TLimit, TActivatorData, TRegistrationStyle>(
            this IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registrationBuilder,
            Type serviceType,
            IEnumerable<Type> interceptors)
            where TActivatorData : ReflectionActivatorData
        {
            if (serviceType.IsInterface)
            {
                registrationBuilder = registrationBuilder.EnableInterfaceInterceptors();
            }
            else
            {
                (registrationBuilder as IRegistrationBuilder<TLimit, ConcreteReflectionActivatorData, TRegistrationStyle>)?.EnableClassInterceptors();
            }

            foreach (var interceptor in interceptors)
            {
                registrationBuilder.InterceptedBy(
                    typeof(AbpAsyncDeterminationInterceptor<>).MakeGenericType(interceptor)
                );
            }

            return registrationBuilder;
        }
    }
}
