using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeEndOfDay
    {
        [TestMethod]
        public void EndOfDay()
        {
            var @this = global::System.DateTime.Now;

            var value = @this.EndOfDay();

            Assert.AreEqual(new global::System.DateTime(value.Year, value.Month, value.Day, 23, 59, 59, 999), value);
        }
    }
}
