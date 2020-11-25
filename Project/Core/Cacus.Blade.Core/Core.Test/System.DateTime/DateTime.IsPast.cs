using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsPast
    {
        [TestMethod]
        public void IsPast()
        {
            var @this = global::System.DateTime.Now.AddDays(1);

            var value1 = @this.IsPast();
            var value2 = @this.AddYears(-1).IsPast();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
