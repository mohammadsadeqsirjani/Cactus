using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringBr2Nl
    {
        [TestMethod]
        public void Br2Nl()
        {
            const string @this = "Fizz<br />Buzz";

            var result = @this.Br2Nl();

            Assert.AreEqual("Fizz" + global::System.Environment.NewLine + "Buzz", result);
        }
    }
}
