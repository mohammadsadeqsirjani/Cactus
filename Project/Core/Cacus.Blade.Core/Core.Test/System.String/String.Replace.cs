using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringReplace
    {
        [TestMethod]
        public void ReplaceByEmpty()
        {
            const string @this = "FizzBuzz";

            var value = @this.Replace(2, 3, "123456");

            Assert.AreEqual("Fi123456uzz", value);
        }
    }
}
