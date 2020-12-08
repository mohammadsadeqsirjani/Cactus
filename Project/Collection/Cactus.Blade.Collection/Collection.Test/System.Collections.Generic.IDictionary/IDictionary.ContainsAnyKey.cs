using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryContainsAnyKey
    {
        [TestMethod]
        public void ContainsAnyKey()
        {
            var @this = new Dictionary<string, string> { { "Fizz", "Buzz" }, { "Fizz2", "Buzz2" } };

            var value1 = @this.ContainsAnyKey("Fizz", "Fizz3");
            var value2 = @this.ContainsAnyKey("Fizz3", "Fizz4");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
