using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryAddIfNotContainsKey
    {
        [TestMethod]
        public void AddIfNotContainsKey()
        {
            var @this = new Dictionary<string, string>();

            @this.AddIfNotContainsKey("Fizz", "FizzBuzz");
            @this.AddIfNotContainsKey("Fizz", () => "Buzz");

            Assert.AreEqual("FizzBuzz", @this["Fizz"]);
        }
    }
}
