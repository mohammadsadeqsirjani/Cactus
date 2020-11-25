using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryContainsAllKey
    {
        [TestMethod]
        public void ContainsAllKey()
        {
            var @this = new Dictionary<string, string> { { "Fizz", "Buzz" }, { "Fizz2", "Buzz2" } };

            var value1 = @this.ContainsAllKey("Fizz", "Fizz2");
            var value2 = @this.ContainsAllKey("Fizz", "Fizz3");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
