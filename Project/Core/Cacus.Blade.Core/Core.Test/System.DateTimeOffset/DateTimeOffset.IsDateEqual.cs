using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsDateEqual
    {
        [TestMethod]
        public void IsDateEqual()
        {
            var thisMorning = new global::System.DateTimeOffset(2014, 04, 12, 8, 0, 0, global::System. TimeSpan.Zero);
            var thisAfternoon = new global::System.DateTimeOffset(2014, 04, 12, 17, 0, 0, global::System. TimeSpan.Zero);

            var result = thisMorning.IsDateEqual(thisAfternoon);

            Assert.IsTrue(result);
        }
    }
}
