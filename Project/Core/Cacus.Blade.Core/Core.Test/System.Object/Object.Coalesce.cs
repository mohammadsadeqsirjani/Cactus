using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class System_Object_Coalesce
    {
        [TestMethod]
        public void Coalesce()
        {
            object @thisNull = null;
            object @thisNotNull = "Fizz";

            var result1 = @thisNull.Coalesce(null, null, "Fizz", "Buzz");
            var result2 = @thisNull.Coalesce(null, "Fizz", null, "Buzz");
            var result3 = @thisNotNull.Coalesce(null, null, null, "Buzz");

            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Fizz", result2);
            Assert.AreEqual("Fizz", result3);
        }
    }
}
