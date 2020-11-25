using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringNl2Br
    {
        [TestMethod]
        public void Nl2Br()
        {
            var @this = "Fizz" + global::System.Environment.NewLine + "Buzz";

            var result = @this.Nl2Br();

            Assert.AreEqual("Fizz<br />Buzz", result);
        }
    }
}
