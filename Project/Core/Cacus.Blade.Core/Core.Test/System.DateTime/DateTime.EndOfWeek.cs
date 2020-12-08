using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeEndOfWeek
    {
        [TestMethod]
        public void EndOfWeek()
        {
            var @this = new global::System.DateTime(2014, 04, 16);

            var value = @this.EndOfWeek();

            Assert.AreEqual(new global::System.DateTime(2014, 04, 19, 23, 59, 59, 999), value);
        }
    }
}
