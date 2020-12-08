using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsDateEqual
    {
        [TestMethod]
        public void IsDateEqual()
        {
            var thisMorning = new global::System.DateTime(2014, 04, 12, 8, 0, 0);
            var thisAfternoon = new global::System.DateTime(2014, 04, 12, 17, 0, 0);

            var result = thisMorning.IsDateEqual(thisAfternoon);

            Assert.IsTrue(result);
        }
    }
}
