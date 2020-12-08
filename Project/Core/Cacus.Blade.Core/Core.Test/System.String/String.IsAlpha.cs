using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsAlpha
    {
        [TestMethod]
        public void IsAlpha()
        {
            const string thisAlpha = "abc";
            const string thisNotAlpha = "abc123";

            var value1 = @thisAlpha.IsAlpha();
            var value2 = @thisNotAlpha.IsAlpha();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
