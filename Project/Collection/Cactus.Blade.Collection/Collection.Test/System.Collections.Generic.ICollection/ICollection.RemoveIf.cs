using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionRemoveIf
    {
        [TestMethod]
        public void RemoveIf()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            @this.RemoveIf("zA", @this.Contains);

            Assert.AreEqual(2, @this.Count);
        }
    }
}
