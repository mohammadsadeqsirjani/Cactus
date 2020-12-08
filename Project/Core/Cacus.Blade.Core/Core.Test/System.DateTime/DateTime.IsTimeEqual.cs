using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsTimeEqual
    {
        [TestMethod]
        public void IsTimeEqual()
        {
            var thisToday = global::System.DateTime.Today;
            var thisYesterday = thisToday.AddDays(-1);

            var result = thisYesterday.IsTimeEqual(thisToday);

            Assert.IsTrue(result);
        }
    }
}
