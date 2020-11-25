using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryToNameValueCollection
    {
        [TestMethod]
        public void ToNameValueCollection()
        {
            var @this = new Dictionary<string, string> { { "Fizz", "Buzz" } };

            var result = @this.ToNameValueCollection();

            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}
