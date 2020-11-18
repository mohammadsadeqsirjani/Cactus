namespace Caching.Test.System.Object
{
    public class CacheTest
    {
        private int _cache;

        public int Increment()
        {
            _cache++;
            return _cache;
        }
    }
}