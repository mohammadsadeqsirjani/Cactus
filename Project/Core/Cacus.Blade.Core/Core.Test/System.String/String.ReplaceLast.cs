using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringReplaceLast
    {
        [TestMethod]
        public void ReplaceLast()
        {
            const string @this = "zzzzz";

            var result1 = @this.ReplaceLast("z", "a");
            var result2 = @this.ReplaceLast(3, "z", "a");
            var result3 = @this.ReplaceLast(3, "z", "za");
            var result4 = @this.ReplaceLast(4, "z", "a");
            var result5 = @this.ReplaceLast(5, "z", "a");
            var result6 = @this.ReplaceLast(10, "z", "a");

            Assert.AreEqual("zzzza", result1);
            Assert.AreEqual("zzaaa", result2);
            Assert.AreEqual("zzzazaza", result3);
            Assert.AreEqual("zaaaa", result4);
            Assert.AreEqual("aaaaa", result5);
            Assert.AreEqual("aaaaa", result6);
        }
    }
}
