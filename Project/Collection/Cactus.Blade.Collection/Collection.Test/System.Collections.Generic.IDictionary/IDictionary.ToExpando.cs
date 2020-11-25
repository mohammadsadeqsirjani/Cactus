using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.IDictionary
{
    [TestClass]
    public class DictionaryToExpando
    {
        [TestMethod]
        public void ToExpando()
        {
            var @this = new Dictionary<string, object> { { "Fizz", "Buzz" } };

            dynamic result = @this.ToExpando();

            Assert.AreEqual("Buzz", result.Fizz);
        }
    }
}
