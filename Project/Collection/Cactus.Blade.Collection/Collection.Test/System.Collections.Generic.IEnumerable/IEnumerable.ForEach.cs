using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableForEach
    {
        [TestMethod]
        public void ForEach()
        {
            var result1 = "";
            var result2 = "";
            var sum2 = 0;

            var @this = new List<string> { "zA", "zB", "C" }.AsEnumerable();

            @this.ForEach(s => result1 += s);
            @this.ForEach((s, i) =>
            {
                result2 += s;
                sum2 += i;
            });

            Assert.AreEqual("zAzBC", result1);

            Assert.AreEqual("zAzBC", result2);
            Assert.AreEqual(3, sum2);
        }
    }
}
