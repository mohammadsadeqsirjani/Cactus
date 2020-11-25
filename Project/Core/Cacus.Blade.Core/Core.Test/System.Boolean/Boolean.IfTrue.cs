using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Boolean
{
    [TestClass]
    public class BooleanIfTrue
    {
        [TestMethod]
        public void IfTrue()
        {
            var value1 = "";
            var value2 = "";

            const bool conditionTrue = true;
            const bool conditionFalse = false;

            conditionTrue.IfTrue(() => value1 = "FizzBuzz");
            conditionFalse.IfTrue(() => value2 = "FizzBuzz");

            Assert.AreEqual("FizzBuzz", value1);
            Assert.AreEqual("", value2);
        }
    }
}
