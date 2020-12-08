using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableContainsAll
    {
        [TestMethod]
        public void ContainsAll()
        {
            var @this = new List<string> { "zA", "zB", "C" }.AsEnumerable();

            var value1 = @this.ContainsAll("zA", "zB");
            var value2 = @this.ContainsAll("zA", "2");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
