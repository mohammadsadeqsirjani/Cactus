using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryGetOrAdd
    {
        [TestMethod]
        public void GetOrAdd()
        {
            var @this = new Dictionary<string, string>();

            var value1 = @this.GetOrAdd("Fizz", "Buzz");
            var value2 = @this.GetOrAdd("Fizz", "Buzz2");
            var value3 = @this.GetOrAdd("Fizz2", s => "Buzz");

            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz", value2);
            Assert.AreEqual("Buzz", value3);
        }
    }
}
