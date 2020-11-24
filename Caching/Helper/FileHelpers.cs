using System.IO;

namespace Cactus.Blade.Caching.Helper
{
    internal static class FileHelpers
    {
        internal static string GetLocalStoreFilePath(string filename)
        {
            return Path.Combine(System.AppContext.BaseDirectory, filename);
        }
    }
}
