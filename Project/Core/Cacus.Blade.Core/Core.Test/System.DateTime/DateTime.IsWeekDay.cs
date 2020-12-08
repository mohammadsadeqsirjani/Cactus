using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsWeekDay
    {
        [TestMethod]
        public void IsWeekDay()
        {
            var thisFriday = new global::System.DateTime(2013, 11, 22);
            var thisSaturday = new global::System.DateTime(2013, 11, 23);

            var value1 = thisFriday.IsWeekDay();
            var value2 = thisSaturday.IsWeekDay();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
