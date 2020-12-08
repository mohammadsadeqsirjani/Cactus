using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsMorning
    {
        [TestMethod]
        public void IsMorning()
        {
            var thisMorning = new global::System.DateTime(2014, 04, 12, 8, 0, 0);
            var thisAfternoon = new global::System.DateTime(2014, 04, 12, 17, 0, 0);

            var result1 = thisMorning.IsMorning();
            var result2 = thisAfternoon.IsMorning();

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
