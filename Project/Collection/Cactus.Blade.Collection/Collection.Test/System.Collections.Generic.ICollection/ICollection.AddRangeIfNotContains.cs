using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionAddRangeIfNotContains
    {
        [TestMethod]
        public void AddRangeIfNotContains()
        {
            var @this = new List<string> { "FizzExisting" };

            @this.AddRangeIfNotContains("Fizz");
            @this.AddRangeIfNotContains("FizzExisting", "Buzz");

            Assert.AreEqual(3, @this.Count);
        }
    }
}
