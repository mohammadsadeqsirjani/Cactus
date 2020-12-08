using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            const string thisValue = "Fizz";
            string @thisNull = null;

            var value1 = @thisValue.IsNullOrEmpty();
            var value2 = @thisNull.IsNullOrEmpty();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
