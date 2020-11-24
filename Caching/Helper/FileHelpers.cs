using System.IO;

namespace Cactus.Blade.Caching.Helper
{
    public static class FileHelpers
    {
        public static string GetLocalStoreFilePath(string filename)
        {
            return Path.Combine(System.AppContext.BaseDirectory, filename);
        }
    }
}
