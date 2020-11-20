//using Microsoft.VisualStudio.TestTools.UnitTesting;

//// ReSharper disable once CheckNamespace
//namespace Caching.Blade.Caching.Test
//{
//    [TestClass]
//    public class Object
//    {
//        [TestMethod]
//        public void FromCache()
//        {
//            var cache1 = new CacheTest();
//            var cache2 = new CacheTest();

//            int cache11 = cache1.FromCache(i => cache1.Increment());
//            int cache12 = cache1.FromCache(i => cache1.Increment());

//            int cache21 = cache1.FromCache("CustomKey", i => cache2.Increment());
//            int cache22 = cache1.FromCache("CustomKey", i => cache2.Increment());

//            int cache31 = cache1.FromCache("CustomKeyWithValue", 1);
//            int cache32 = cache1.FromCache("CustomKeyWithValue", 2);

//            Assert.AreEqual(1, cache11);
//            Assert.AreEqual(1, cache12);

//            Assert.AreEqual(1, cache21);
//            Assert.AreEqual(1, cache22);

//            Assert.AreEqual(1, cache31);
//            Assert.AreEqual(1, cache32);
//        }

//        public class CacheTest
//        {
//            public int Cache;

//            public int Increment()
//            {
//                Cache++;
//                return Cache;
//            }
//        }
//    }
//}
