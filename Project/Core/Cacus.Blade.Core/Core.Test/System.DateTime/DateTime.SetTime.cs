using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeSetTime
    {
        [TestMethod]
        public void SetTime()
        {
            var thisToday = global::System.DateTime.Today;

            var result = thisToday.SetTime(15, 0);

            Assert.AreEqual(15, result.Hour);
        }
    }
}
