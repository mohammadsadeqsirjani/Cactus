using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            const string thisEmpty = "";
            const string thisNotEmpty = "FizzBuzz";

            var result1 = @thisEmpty.IsEmpty();
            var result2 = @thisNotEmpty.IsEmpty();

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
