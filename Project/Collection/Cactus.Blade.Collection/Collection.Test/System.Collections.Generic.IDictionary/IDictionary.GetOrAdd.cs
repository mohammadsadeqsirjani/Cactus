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

            string value1 = @this.GetOrAdd("Fizz", "Buzz");
            string value2 = @this.GetOrAdd("Fizz", "Buzz2");
            string value3 = @this.GetOrAdd("Fizz2", s => "Buzz");

            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz", value2);
            Assert.AreEqual("Buzz", value3);
        }
    }
}
