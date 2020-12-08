using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeTomorrow
    {
        [TestMethod]
        public void Tomorrow()
        {
            var @this = global::System.DateTime.Now;

            var result = @this.Tomorrow();

            Assert.AreEqual(@this.AddDays(1).Day, result.Day);
        }
    }
}
