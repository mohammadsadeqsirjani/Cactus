using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsAfternoon
    {
        [TestMethod]
        public void IsAfternoon()
        {
            var thisMorning = new global::System.DateTime(2014, 04, 12, 8, 0, 0);
            var thisAfternoon = new global::System.DateTime(2014, 04, 12, 17, 0, 0);

            var result1 = thisMorning.IsAfternoon();
            var result2 = thisAfternoon.IsAfternoon();

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}
