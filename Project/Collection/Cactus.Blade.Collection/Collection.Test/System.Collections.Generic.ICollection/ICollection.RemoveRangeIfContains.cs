using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionRemoveRangeIfContains
    {
        [TestMethod]
        public void RemoveRangeIfContains()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            @this.RemoveRangeIfContains("zA", "D");

            Assert.AreEqual(2, @this.Count);
        }
    }
}
