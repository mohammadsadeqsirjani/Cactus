using System;

namespace Caching.Test
{
    internal static class TestHelpers
    {
        /// <summary>
        /// Configuration that can be used for initializing a unique LocalStorage instance.
        /// </summary>
        internal static Cactus.Blade.Caching.ICachingConfiguration UniqueInstance()
        {
            return new Cactus.Blade.Caching.CachingConfiguration()
            {
                Filename = Guid.NewGuid().ToString()
            };
        }
    }
}
