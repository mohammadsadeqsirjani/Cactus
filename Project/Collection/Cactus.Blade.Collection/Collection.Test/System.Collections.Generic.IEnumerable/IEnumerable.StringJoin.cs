using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableStringJoin
    {
        [TestMethod]
        public void StringJoin()
        {
            var @this = new List<string> { "zA", "zB", "C" }.AsEnumerable();

            var result = @this.StringJoin(";");

            Assert.AreEqual("zA;zB;C", result);
        }
    }
}
