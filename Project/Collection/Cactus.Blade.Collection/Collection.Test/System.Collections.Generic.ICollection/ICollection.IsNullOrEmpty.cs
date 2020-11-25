using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionIsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            var @this = new List<string>();

            var value1 = @this.IsNullOrEmpty();

            @this.Add("Fizz");
            var value2 = @this.IsNullOrEmpty();

            @this = null;
            var value3 = @this.IsNullOrEmpty();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
        }
    }
}
