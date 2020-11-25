using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            const string thisValue = "Fizz";
            string @thisNull = null;

            var value1 = @thisValue.IsNotNullOrEmpty();
            var value2 = @thisNull.IsNotNullOrEmpty();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
