using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryRemoveIfContainsKey
    {
        [TestMethod]
        public void RemoveIfContainsKey()
        {
            var @this = new Dictionary<string, string> { { "Fizz", "Buzz" } };

            @this.RemoveIfContainsKey("Fizz");
            @this.RemoveIfContainsKey("Fizz2");

            Assert.AreEqual(0, @this.Count);
        }
    }
}
