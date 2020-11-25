using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class EnumerableIsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            var @thisEmpty = new List<string>().AsEnumerable();
            var @thisNotEmpty = new List<string> { "Fizz" }.AsEnumerable();

            var result2 = @thisEmpty.IsEmpty();
            var result3 = @thisNotEmpty.IsEmpty();

            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}
