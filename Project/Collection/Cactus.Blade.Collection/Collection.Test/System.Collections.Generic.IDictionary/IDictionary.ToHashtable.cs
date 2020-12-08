using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryToHashtable
    {
        [TestMethod]
        public void ToHashtable()
        {
            var @this = new Dictionary<string, string> { { "Fizz", "Buzz" } };

            var result = @this.ToHashtable();

            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}
