using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeStartOfWeek
    {
        [TestMethod]
        public void StartOfWeek()
        {
            var @this = new global::System.DateTime(2014, 04, 16);

            var value = @this.StartOfWeek();

            Assert.AreEqual(new global::System.DateTime(2014, 04, 13), value);
        }
    }
}
