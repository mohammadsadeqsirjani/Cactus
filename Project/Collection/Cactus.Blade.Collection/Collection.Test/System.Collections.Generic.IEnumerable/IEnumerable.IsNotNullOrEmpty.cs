using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableIsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            List<string> @thisNull = null;

            var @thisEmpty = new List<string>().AsEnumerable();
            var @thisNotEmpty = new List<string> { "Fizz" }.AsEnumerable();

            var result1 = @thisNull.IsNotNullOrEmpty();
            var result2 = @thisEmpty.IsNotNullOrEmpty();
            var result3 = @thisNotEmpty.IsNotNullOrEmpty();

            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}
