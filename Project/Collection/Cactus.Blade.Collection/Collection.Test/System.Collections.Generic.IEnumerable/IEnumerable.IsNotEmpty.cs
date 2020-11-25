using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableIsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            var @thisEmpty = new List<string>().AsEnumerable();
            var @thisNotEmpty = new List<string> { "Fizz" }.AsEnumerable();

            var result2 = @thisEmpty.IsNotEmpty();
            var result3 = @thisNotEmpty.IsNotEmpty();

            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}
