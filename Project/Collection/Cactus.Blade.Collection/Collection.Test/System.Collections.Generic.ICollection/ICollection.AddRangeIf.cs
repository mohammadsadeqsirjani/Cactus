using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionAddRangeIf
    {
        [TestMethod]
        public void AddRangeIf()
        {
            var @this = new List<string> { "FizzExisting" };

            @this.AddRangeIf(x => !@this.Contains(x), "Fizz");
            @this.AddRangeIf(x => !@this.Contains(x), "FizzExisting", "Buzz");

            Assert.AreEqual(3, @this.Count);
        }
    }
}
