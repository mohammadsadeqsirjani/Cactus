using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            var @this = new List<string> { "zA", "zB", "C" }.AsEnumerable();

            var value1 = @this.ContainsAny("1", "zA", "3");
            var value2 = @this.ContainsAny("1", "2", "3");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
