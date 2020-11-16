using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Core.System.Object
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method that shallow copy.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A T.</returns>
        public static T ShallowCopy<T>(this T @this)
        {
            var method = @this
                .GetType()
                .GetMethod("MemberwiseClone", BindingFlags.NonPublic |
                                              BindingFlags.Instance);
            return (T)method?.Invoke(@this, null);
        }
    }
}
