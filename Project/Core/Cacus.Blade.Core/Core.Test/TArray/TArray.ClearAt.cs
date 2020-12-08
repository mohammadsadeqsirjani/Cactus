using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.TArray
{
    [TestClass]
    public class ArrayClearAt
    {
        [TestMethod]
        public void ClearAt()
        {
            var @this = new[] { "Fizz", "Buzz" };

            @this.ClearAt(0);

            Assert.AreEqual(null, @this[0]);
            Assert.AreEqual("Buzz", @this[1]);
        }
    }
}
