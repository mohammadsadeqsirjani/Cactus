using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            const string thisEmpty = "";
            const string thisNotEmpty = "FizzBuzz";

            var result1 = @thisEmpty.IsNotEmpty();
            var result2 = @thisNotEmpty.IsNotEmpty();

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}
