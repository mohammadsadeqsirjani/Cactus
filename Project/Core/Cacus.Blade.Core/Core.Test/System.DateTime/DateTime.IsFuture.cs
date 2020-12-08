using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsFuture
    {
        [TestMethod]
        public void IsFuture()
        {
            var @this = global::System.DateTime.Now.AddDays(1);

            var value1 = @this.IsFuture();
            var value2 = @this.AddYears(-1).IsFuture();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
