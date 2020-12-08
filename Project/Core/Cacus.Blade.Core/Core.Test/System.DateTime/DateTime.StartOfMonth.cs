using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeStartOfMonth
    {
        [TestMethod]
        public void StartOfMonth()
        {
            var @this = global::System.DateTime.Now;

            var value = @this.StartOfMonth();

            Assert.AreEqual(new global::System.DateTime(value.Year, value.Month, 1), value);
        }
    }
}
