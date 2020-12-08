using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryToSortedDictionary
    {
        [TestMethod]
        public void ToSortedDictionary()
        {
            var @this = new Dictionary<string, string> { { "Fizz", "Buzz" } };

            var result = @this.ToSortedDictionary();

            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}
