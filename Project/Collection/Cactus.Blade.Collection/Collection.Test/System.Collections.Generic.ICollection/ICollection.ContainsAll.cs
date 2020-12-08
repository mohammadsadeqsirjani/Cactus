using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionContainsAll
    {
        [TestMethod]
        public void ContainsAll()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            var value1 = @this.ContainsAll("zA", "zB");
            var value2 = @this.ContainsAll("zA", "2");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
