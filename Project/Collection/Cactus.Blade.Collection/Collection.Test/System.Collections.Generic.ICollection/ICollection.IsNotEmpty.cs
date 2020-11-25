using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionIsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            var @this = new List<string>();

            var value1 = @this.IsNotEmpty();

            @this.Add("Fizz");
            var value2 = @this.IsNotEmpty();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
