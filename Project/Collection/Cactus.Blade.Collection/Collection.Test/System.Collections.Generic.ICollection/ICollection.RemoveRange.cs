using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionRemoveRange
    {
        [TestMethod]
        public void RemoveRange()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            @this.RemoveRange("zA", "zB");

            Assert.AreEqual(1, @this.Count);
        }
    }
}
