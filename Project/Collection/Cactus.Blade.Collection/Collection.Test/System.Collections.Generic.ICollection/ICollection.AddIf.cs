using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionAddIf
    {
        [TestMethod]
        public void AddIf()
        {
            var @this = new List<string>();

            @this.AddIf(s => true, "Fizz");
            @this.AddIf(s => false, "Buzz");

            Assert.IsTrue(@this.Contains("Fizz"));
            Assert.IsFalse(@this.Contains("Buzz"));
        }
    }
}
