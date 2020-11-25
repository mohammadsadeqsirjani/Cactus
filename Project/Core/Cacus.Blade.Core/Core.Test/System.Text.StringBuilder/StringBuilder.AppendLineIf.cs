using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderAppendLineIf
    {
        [TestMethod]
        public void AppendLineIf()
        {
            var @this = new global::System.Text.StringBuilder();

            @this.AppendLineIf(x => x.Contains("F"), "Fizz", "Buzz");

            Assert.AreEqual("Fizz" + "\n", @this.ToString());
        }
    }
}
