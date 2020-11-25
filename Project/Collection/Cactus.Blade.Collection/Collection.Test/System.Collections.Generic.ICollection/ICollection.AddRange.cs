using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionAddRange
    {
        [TestMethod]
        public void AddRange()
        {
            var @this = new List<string>();


            @this.AddRange("Fizz", "Buzz");

            Assert.IsTrue(@this.Contains("Fizz"));
            Assert.IsTrue(@this.Contains("Buzz"));
        }
    }
}
