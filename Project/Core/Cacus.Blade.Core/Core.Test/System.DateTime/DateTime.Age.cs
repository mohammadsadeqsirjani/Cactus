using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class DateTimeAge
    {
        [TestMethod]
        public void Age()
        {
            var @this = new global::System.DateTime(1981, 01, 01);

            var result = @this.Age();

            Assert.AreEqual(global::System.DateTime.Now.Year - 1981, result);
        }
    }
}
