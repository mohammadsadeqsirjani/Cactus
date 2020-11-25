using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsAlphaNumeric
    {
        [TestMethod]
        public void IsAlphaNumeric()
        {
            const string thisAlphaNumeric = "abc123";
            const string thisNotAlphaNumeric = "abc123!<>";

            var value1 = @thisAlphaNumeric.IsAlphaNumeric();
            var value2 = @thisNotAlphaNumeric.IsAlphaNumeric();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
