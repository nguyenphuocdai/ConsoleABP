﻿using RabbitMQ.Client;
using System;

namespace Abp.RabbitMQ.Interfaces
{
    public interface IChannelAccessor : IDisposable
    {
        /// <summary>
        /// Reference to the channel.
        /// Never dispose the <see cref="Channel"/> object.
        /// Instead, dispose the <see cref="IChannelAccessor"/> after usage.
        /// </summary>
        IModel Channel { get; }

        /// <summary>
        /// Name of the channel.
        /// </summary>
        string Name { get; }
    }
}
