using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionIsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            var @this = new List<string>();

            var value1 = @this.IsNotNullOrEmpty();

            @this.Add("Fizz");
            var value2 = @this.IsNotNullOrEmpty();

            @this = null;
            var value3 = @this.IsNotNullOrEmpty();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
            Assert.IsFalse(value3);
        }
    }
}