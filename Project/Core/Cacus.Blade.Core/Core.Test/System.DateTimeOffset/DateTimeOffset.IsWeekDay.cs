using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsWeekDay
    {
        [TestMethod]
        public void IsWeekDay()
        {
            var thisFriday = new global::System.DateTimeOffset(2013, 11, 22, 0, 0, 0, global::System. TimeSpan.Zero);
            var thisSaturday = new global::System.DateTimeOffset(2013, 11, 23, 0, 0, 0, global::System. TimeSpan.Zero);

            var value1 = thisFriday.IsWeekDay();
            var value2 = thisSaturday.IsWeekDay();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
