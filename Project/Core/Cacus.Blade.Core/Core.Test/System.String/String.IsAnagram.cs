using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsAnagram
    {
        [TestMethod]
        public void IsAnagram()
        {
            const string @this = "abba";

            var value1 = @this.IsAnagram("abba");
            var value2 = @this.IsAnagram("abab");
            var value3 = @this.IsAnagram("aba");
            var value4 = @this.IsAnagram("");
            var value5 = @this.IsAnagram("aba b");

            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsFalse(value3);
            Assert.IsFalse(value4);
            Assert.IsFalse(value5);
        }
    }
}
