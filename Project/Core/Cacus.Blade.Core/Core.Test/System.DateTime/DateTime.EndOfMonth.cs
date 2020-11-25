using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeEndOfMonth
    {
        [TestMethod]
        public void EndOfMonth()
        {
            var @this = new global::System.DateTime(2013, 12, 22);

            var value = @this.EndOfMonth();

            Assert.AreEqual(new global::System.DateTime(2013, 12, 31, 23, 59, 59, 999), value);
        }
    }
}
