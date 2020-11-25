using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.TArray
{
    [TestClass]
    public class ArrayClearAll
    {
        [TestMethod]
        public void ClearAll()
        {
            var @this = new[] { "Fizz", "Buzz" };

            @this.ClearAll();

            Assert.AreEqual(null, @this[0]);
            Assert.AreEqual(null, @this[1]);
        }
    }
}
