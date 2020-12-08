using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeStartOfYear
    {
        [TestMethod]
        public void StartOfYear()
        {
            var @this = global::System.DateTime.Now;

            var value = @this.StartOfYear();

            Assert.AreEqual(new global::System.DateTime(value.Year, 1, 1), value);
        }
    }
}
