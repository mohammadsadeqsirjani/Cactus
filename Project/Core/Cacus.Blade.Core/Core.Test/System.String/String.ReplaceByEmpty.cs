using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringReplaceByEmpty
    {
        [TestMethod]
        public void ReplaceByEmpty()
        {
            const string @this = "FizzBuzz";

            var value = @this.ReplaceByEmpty("z");

            Assert.AreEqual("FiBu", value);
        }
    }
}
