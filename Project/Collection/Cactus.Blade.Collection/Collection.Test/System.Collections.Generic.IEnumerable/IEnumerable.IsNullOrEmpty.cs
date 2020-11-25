using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableIsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            List<string> @thisNull = null;
            var @thisEmpty = new List<string>().AsEnumerable();
            var @thisNotEmpty = new List<string> { "Fizz" }.AsEnumerable();

            var result1 = @thisNull.IsNullOrEmpty();
            var result2 = @thisEmpty.IsNullOrEmpty();
            var result3 = @thisNotEmpty.IsNullOrEmpty();

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}
