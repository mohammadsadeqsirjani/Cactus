using System;
using System.ComponentModel;

namespace Core.System.Object
{
    public static partial class Extension
    {
        /// <summary>
        ///     A System.Object extension method that converts this object to an or default.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">this.</param>
        /// <param name="factory">The default value factory.</param>
        /// <returns>The given data converted to a T.</returns>

        public static T ToOrDefault<T>(this object @this, Func<object, T> factory)
        {
            try
            {
                if (@this == null) return default;

                var targetType = typeof(T);

                if (@this.GetType() == targetType)
                {
                    return (T)@this;
                }

                var converter = TypeDescriptor.GetConverter(@this);
                if (converter.CanConvertTo(targetType))
                    return (T)converter.ConvertTo(@this, targetType);

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter.CanConvertFrom(@this.GetType()))
                    return (T)converter.ConvertFrom(@this);

                if (@this == DBNull.Value)
                    return (T)(null as object);

                return (T)@this;
            }
            catch (Exception)
            {
                return factory(@this);
            }
        }

        /// <summary>
        ///     A System.Object extension method that converts this object to an or default.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">this.</param>
        /// <param name="factory">The default value factory.</param>
        /// <returns>The given data converted to a T.</returns>

        public static T ToOrDefault<T>(this object @this, Func<T> factory)
        {
            return @this.ToOrDefault(o => factory());
        }

        /// <summary>
        ///     A System.Object extension method that converts this object to an or default.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">this.</param>
        /// <returns>The given data converted to a T.</returns>
        public static T ToOrDefault<T>(this object @this)
        {
            return @this.ToOrDefault(o => default(T));
        }

        /// <summary>
        ///     A System.Object extension method that converts this object to an or default.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">this.</param>
        /// <param name="default">The default value.</param>
        /// <returns>The given data converted to a T.</returns>
        public static T ToOrDefault<T>(this object @this, T @default)
        {
            return @this.ToOrDefault(o => @default);
        }
    }
}
