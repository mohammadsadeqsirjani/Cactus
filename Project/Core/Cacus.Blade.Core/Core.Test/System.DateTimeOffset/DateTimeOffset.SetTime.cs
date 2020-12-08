using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetSetTime
    {
        [TestMethod]
        public void SetTime()
        {
            var thisToday = global::System.DateTimeOffset.Now;

            var result = thisToday.SetTime(15);

            Assert.AreEqual(15, result.Hour);
        }
    }
}
