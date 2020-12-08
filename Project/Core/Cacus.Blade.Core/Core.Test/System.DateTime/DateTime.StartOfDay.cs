using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeStartOfDay
    {
        [TestMethod]
        public void StartOfDay()
        {
            var @this = global::System.DateTime.Now;

            var value = @this.StartOfDay();

            Assert.AreEqual(new global::System.DateTime(value.Year, value.Month, value.Day), value);
        }
    }
}
