﻿using Abp.Core.AbpModularity.Helper;
using Abp.Core.AbpModularity.Interfaces;
using JetBrains.Annotations;
using System;
using System.Linq;

namespace Abp.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EventNameAttribute : Attribute, IEventNameProvider
    {
        public virtual string Name { get; }

        public EventNameAttribute([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
        }

        public static string GetNameOrDefault<TEvent>()
        {
            return GetNameOrDefault(typeof(TEvent));
        }

        public static string GetNameOrDefault([NotNull] Type eventType)
        {
            Check.NotNull(eventType, nameof(eventType));

            return eventType
                       .GetCustomAttributes(true)
                       .OfType<IEventNameProvider>()
                       .FirstOrDefault()
                       ?.GetName(eventType)
                   ?? eventType.FullName;
        }

        public string GetName(Type eventType)
        {
            return Name;
        }
    }
}
