using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetYesterday
    {
        [TestMethod]
        public void Yesterday()
        {
            var @this = global::System.DateTimeOffset.Now;

            var result = @this.Yesterday();

            Assert.AreEqual(@this.AddDays(-1).Day, result.Day);
        }
    }
}
