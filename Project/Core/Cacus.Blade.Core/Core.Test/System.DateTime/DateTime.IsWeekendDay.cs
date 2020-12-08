using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsWeekendDay
    {
        [TestMethod]
        public void IsWeekendDay()
        {
            var thisFriday = new global::System.DateTime(2013, 11, 22);
            var thisSaturday = new global::System.DateTime(2013, 11, 23);

            var value1 = thisFriday.IsWeekendDay();
            var value2 = thisSaturday.IsWeekendDay();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
