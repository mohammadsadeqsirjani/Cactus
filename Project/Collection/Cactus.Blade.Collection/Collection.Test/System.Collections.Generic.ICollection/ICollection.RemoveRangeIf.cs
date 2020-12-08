using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionRemoveRangeIf
    {
        [TestMethod]
        public void RemoveRangeIf()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            @this.RemoveRangeIf(x => x.StartsWith("z"), "zA", "zB", "C");

            Assert.AreEqual(1, @this.Count);
        }
    }
}
