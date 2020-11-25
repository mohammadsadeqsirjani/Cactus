using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringReplaceFirst
    {
        [TestMethod]
        public void ReplaceFirst()
        {
            const string @this = "zzzzz";

            var result1 = @this.ReplaceFirst("z", "a");
            var result2 = @this.ReplaceFirst(3, "z", "a");
            var result3 = @this.ReplaceFirst(3, "z", "za");
            var result4 = @this.ReplaceFirst(4, "z", "a");
            var result5 = @this.ReplaceFirst(5, "z", "a");
            var result6 = @this.ReplaceFirst(10, "z", "a");

            Assert.AreEqual("azzzz", result1);
            Assert.AreEqual("aaazz", result2);
            Assert.AreEqual("zazazazz", result3);
            Assert.AreEqual("aaaaz", result4);
            Assert.AreEqual("aaaaa", result5);
            Assert.AreEqual("aaaaa", result6);
        }
    }
}
