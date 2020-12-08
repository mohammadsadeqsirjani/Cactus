using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionRemoveIfContains
    {
        [TestMethod]
        public void RemoveIfContains()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            @this.RemoveIfContains("zA");

            Assert.AreEqual(2, @this.Count);
        }
    }
}
