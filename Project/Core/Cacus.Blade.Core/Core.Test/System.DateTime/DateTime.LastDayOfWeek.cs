using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeLastDayOfWeek
    {
        [TestMethod]
        public void LastDayOfWeek()
        {
            var @this = new global::System.DateTime(2014, 01, 24);

            var result = @this.LastDayOfWeek();

            Assert.AreEqual(new global::System.DateTime(2014, 01, 25), result.Date);
        }
    }
}
