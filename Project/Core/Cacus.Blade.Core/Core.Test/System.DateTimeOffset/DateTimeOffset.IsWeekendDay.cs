using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsWeekendDay
    {
        [TestMethod]
        public void IsWeekendDay()
        {
            var thisFriday = new global::System.DateTimeOffset(2013, 11, 22, 0, 0, 0, global::System. TimeSpan.Zero);
            var thisSaturday = new global::System.DateTimeOffset(2013, 11, 23, 0, 0, 0, global::System. TimeSpan.Zero);

            var value1 = thisFriday.IsWeekendDay();
            var value2 = thisSaturday.IsWeekendDay();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
