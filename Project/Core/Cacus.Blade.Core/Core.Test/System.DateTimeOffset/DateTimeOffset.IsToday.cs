using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsToday
    {
        [TestMethod]
        public void IsToday()
        {
            var thisToday = global::System.DateTime.Today;
            var thisYesterday = thisToday.AddDays(-1);

            var result1 = thisToday.IsToday();
            var result2 = thisYesterday.IsToday();

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
