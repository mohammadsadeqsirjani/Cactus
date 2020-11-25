using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeStartOfMonth
    {
        [TestMethod]
        public void StartOfMonth()
        {
            global::System.DateTime @this = global::System.DateTime.Now;

            global::System.DateTime value = @this.StartOfMonth();

            Assert.AreEqual(new global::System.DateTime(value.Year, value.Month, 1), value);
        }
    }
}
