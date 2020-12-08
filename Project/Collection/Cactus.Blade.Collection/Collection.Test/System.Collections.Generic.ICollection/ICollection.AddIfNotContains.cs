using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionAddIfNotContains
    {
        [TestMethod]
        public void AddIfNotContains()
        {
            var @this = new List<string> { "FizzExisting" };

            @this.AddIfNotContains("Fizz");
            @this.AddIfNotContains("FizzExisting");

            Assert.AreEqual(2, @this.Count);
        }
    }
}
