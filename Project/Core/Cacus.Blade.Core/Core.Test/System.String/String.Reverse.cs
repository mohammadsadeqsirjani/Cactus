using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringReverse
    {
        [TestMethod]
        public void Reverse()
        {
            const string @this = "FizzBuzz";

            var value = @this.Reverse();

            Assert.AreEqual("zzuBzziF", value);
        }
    }
}
