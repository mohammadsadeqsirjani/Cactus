using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Array
{
    [TestClass]
    public class SystemArrayClearAll
    {
        [TestMethod]
        public void ArrayClearAll()
        {
            global::System.Array @this = new[] { "Fizz", "Buzz" };

            @this.ClearAll();

            Assert.AreEqual(null, @this.GetValue(0));
            Assert.AreEqual(null, @this.GetValue(1));
        }
    }
}
