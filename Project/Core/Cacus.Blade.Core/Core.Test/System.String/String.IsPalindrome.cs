using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsPalindrome
    {
        [TestMethod]
        public void IsPalindrome()
        {
            var value1 = "abba".IsPalindrome();
            var value2 = "ab ba".IsPalindrome();
            var value3 = "ab'ba".IsPalindrome();
            var value4 = "abca".IsPalindrome();
            var value5 = "ab b ab".IsPalindrome();

            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
            Assert.IsFalse(value5);
        }
    }
}
