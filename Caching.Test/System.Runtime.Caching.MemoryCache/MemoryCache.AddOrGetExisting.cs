//using Caching.Test.System.Object;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Runtime.Caching;

//namespace Caching.Test.System.Runtime.Caching.MemoryCache
//{
//    [TestClass]
//    public class MemoryCache
//    {
//        [TestMethod]
//        public void AddOrGetExisting()
//        {
//            var cache2 = new CacheTest();
//            var cache3 = new CacheTest();
//            var cache4 = new CacheTest();

//            var cache = global::System.Runtime.Caching.MemoryCache.Default;

//            var cache11 = cache.AddOrGetExisting("cache1", 1);
//            var cache12 = cache.AddOrGetExisting("cache1", 2);

//            var cache21 = cache.AddOrGetExisting("cache2", i => cache2.Increment());
//            var cache22 = cache.AddOrGetExisting("cache2", i => cache2.Increment());

//            var cache31 = cache.AddOrGetExisting("cache3", i => cache3.Increment(), new CacheItemPolicy());
//            var cache32 = cache.AddOrGetExisting("cache3", i => cache3.Increment(), new CacheItemPolicy());

//            var cache41 = cache.AddOrGetExisting("cache4", i => cache4.Increment(), new DateTimeOffset(new DateTime(2100, 01, 01)));
//            var cache42 = cache.AddOrGetExisting("cache4", i => cache4.Increment(), new DateTimeOffset(new DateTime(2100, 01, 01)));

//            Assert.AreEqual(1, cache11);
//            Assert.AreEqual(1, cache12);

//            Assert.AreEqual(1, cache21);
//            Assert.AreEqual(1, cache22);

//            Assert.AreEqual(1, cache31);
//            Assert.AreEqual(1, cache32);

//            Assert.AreEqual(1, cache41);
//            Assert.AreEqual(1, cache42);
//        }
//    }
//}
