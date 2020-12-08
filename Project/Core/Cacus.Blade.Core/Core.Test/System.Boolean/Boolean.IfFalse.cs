using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Boolean
{
    [TestClass]
    public class BooleanIfFalse
    {
        [TestMethod]
        public void IfFalse()
        {
            var value1 = "";
            var value2 = "";

            const bool conditionTrue = true;
            const bool conditionFalse = false;

            conditionTrue.IfFalse(() => value1 = "FizzBuzz");
            conditionFalse.IfFalse(() => value2 = "FizzBuzz");

            Assert.AreEqual("", value1);
            Assert.AreEqual("FizzBuzz", value2);
        }
    }
}
