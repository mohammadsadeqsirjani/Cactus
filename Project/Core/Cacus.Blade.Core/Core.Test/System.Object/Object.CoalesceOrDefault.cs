using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectCoalesceOrDefault
    {
        [TestMethod]
        public void CoalesceOrDefault()
        {
            object nullObject = null;

            object @thisNull = null;
            object @thisNotNull = "Fizz";

            var result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, "Buzz");
            var result2 = @thisNull.CoalesceOrDefault(() => "Buzz", null, null);
            var result3 = @thisNull.CoalesceOrDefault(x => "Buzz", null, null);
            var result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, "Buzz");

            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("Buzz", result2);
            Assert.AreEqual("Buzz", result3);
            Assert.AreEqual("Fizz", result4);
        }
    }
}
