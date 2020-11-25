using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeEndOfYear
    {
        [TestMethod]
        public void EndOfYear()
        {
            var @this = new global::System.DateTime(2013, 04, 13);

            var value = @this.EndOfYear();

            Assert.AreEqual(new global::System.DateTime(2013, 12, 31, 23, 59, 59, 999), value);
        }
    }
}
