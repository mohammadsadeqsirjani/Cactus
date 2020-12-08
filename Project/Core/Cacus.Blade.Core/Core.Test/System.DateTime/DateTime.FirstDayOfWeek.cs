using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeFirstDayOfWeek
    {
        [TestMethod]
        public void FirstDayOfWeek()
        {
            var @this = new global::System.DateTime(2014, 04, 16);

            var result = @this.FirstDayOfWeek();

            Assert.AreEqual(new global::System.DateTime(2014, 04, 13), result);
        }
    }
}
