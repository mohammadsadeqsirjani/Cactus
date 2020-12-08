using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collection.Test.System.Collections.Specialized.NameValueCollection
{
    [TestClass]
    public class NameValueCollectionToDictionary
    {
        [TestMethod]
        public void ToDictionary()
        {
            var @this = new global::System.Collections.Specialized.NameValueCollection { { "Fizz", "Buzz" } };

            var result = @this.ToDictionary();

            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}
