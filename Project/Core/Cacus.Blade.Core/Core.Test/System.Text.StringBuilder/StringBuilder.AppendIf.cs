using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderAppendIf
    {
        [TestMethod]
        public void AppendIf()
        {
            var @this = new global::System.Text.StringBuilder();

            @this.AppendIf(x => x.Contains("F"), "Fizz", "Buzz");

            Assert.AreEqual("Fizz", @this.ToString());
        }
    }
}
