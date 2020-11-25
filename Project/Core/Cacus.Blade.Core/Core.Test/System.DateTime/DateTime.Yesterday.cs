using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeYesterday
    {
        [TestMethod]
        public void Yesterday()
        {
            var @this = global::System.DateTime.Now;

            var result = @this.Yesterday();

            Assert.AreEqual(@this.AddDays(-1).Day, result.Day);
        }
    }
}
