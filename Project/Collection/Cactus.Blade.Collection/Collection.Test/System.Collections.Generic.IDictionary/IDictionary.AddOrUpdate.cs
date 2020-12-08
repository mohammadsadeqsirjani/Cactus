using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryAddOrUpdate
    {
        [TestMethod]
        public void AddOrUpdate()
        {
            var @this = new Dictionary<string, string>();

            var value1 = @this.AddOrUpdate("Fizz", "Buzz");
            var value2 = @this.AddOrUpdate("Fizz", "Buzz2");

            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz2", value2);
        }
    }
}
