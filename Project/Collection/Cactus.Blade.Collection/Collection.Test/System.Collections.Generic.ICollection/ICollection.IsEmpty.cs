using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionIsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            var @this = new List<string>();

            var value1 = @this.IsEmpty();

            @this.Add("Fizz");

            var value2 = @this.IsEmpty();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
