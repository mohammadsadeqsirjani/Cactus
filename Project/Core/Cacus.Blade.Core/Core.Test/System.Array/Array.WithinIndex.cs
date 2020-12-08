using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Array
{
    [TestClass]
    public class SystemArrayWithinIndex
    {
        [TestMethod]
        public void WithinIndex()
        {
            global::System.Array @this = new[] { "Fizz", "Buzz" };

            var result1 = @this.WithinIndex(1);
            var result2 = @this.WithinIndex(2);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
