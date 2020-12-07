﻿using System;

namespace Cactus.Blade.Logger
{
    /// <summary>
    /// A fluent class to build a Logger.
    /// </summary>
    public class LoggerCreateBuilder
    {
        private readonly Logger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerCreateBuilder"/> class.
        /// </summary>
        /// <param name="logger">The factory.</param>
        public LoggerCreateBuilder(Logger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        /// <summary>
        /// Sets the initial logger name for the logging event.
        /// </summary>
        /// <param name="logger">The name of the logger.</param>
        /// <returns></returns>
        public LoggerCreateBuilder Logger(string logger)
        {
            _logger.Name = logger;

            return this;
        }

        /// <summary>
        /// Sets the initial logger name using the generic type.
        /// </summary>
        /// <typeparam name="TLogger">The type of the logger.</typeparam>
        /// <returns></returns>
        public LoggerCreateBuilder Logger<TLogger>()
        {
            _logger.Name = typeof(TLogger).FullName;

            return this;
        }

        /// <summary>
        /// Sets the initial logger name using the specified type.
        /// </summary>
        /// <param name="type">The type of the logger.</param>
        /// <returns></returns>
        public LoggerCreateBuilder Logger(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            _logger.Name = type.FullName;

            return this;
        }


        /// <summary>
        /// Sets an initial  log context property on the logging event.
        /// </summary>
        /// <param name="name">The name of the context property.</param>
        /// <param name="value">The value of the context property.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">name</exception>
        public LoggerCreateBuilder Property(string name, object value)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            _logger.Properties.Set(name, value);

            return this;
        }
    }
}
