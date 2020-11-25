using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderAppendLineIf
    {
        [TestMethod]
        public void AppendLineIf()
        {
            // Type
            var @this = new global::System.Text.StringBuilder();

            // Exemples
            @this.AppendLineIf(x => x.Contains("F"), "Fizz", "Buzz");

            // Unit Test
            Assert.AreEqual("Fizz" + global::System.Environment.NewLine, @this.ToString());
        }
    }
}
