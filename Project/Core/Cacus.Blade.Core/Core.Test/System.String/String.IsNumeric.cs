using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsNumeric
    {
        [TestMethod]
        public void IsNumeric()
        {
            const string thisNumeric = "123";
            const string thisNotNumeric = "abc123";

            var value1 = @thisNumeric.IsNumeric();
            var value2 = @thisNotNumeric.IsNumeric();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
