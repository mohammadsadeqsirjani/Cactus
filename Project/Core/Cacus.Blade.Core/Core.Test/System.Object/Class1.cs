using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectToInt32OrDefault
    {
        [TestMethod]
        public void ToInt32OrDefault()
        {
            const string thisValid = "32";
            const string thisInvalid = "FizzBuzz";

            var result1 = @thisValid.ToInt32OrDefault();
            var result2 = @thisInvalid.ToInt32OrDefault();
            var result3 = @thisInvalid.ToInt32OrDefault(-1);
            var result4 = @thisInvalid.ToInt32OrDefault(() => -2);

            Assert.AreEqual(32, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-2, result4);
        }
    }
}
