using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            var value1 = @this.ContainsAny("1", "zA", "3");
            var value2 = @this.ContainsAny("1", "2", "3");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
