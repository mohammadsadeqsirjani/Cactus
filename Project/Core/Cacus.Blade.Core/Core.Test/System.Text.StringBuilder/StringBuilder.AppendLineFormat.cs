using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderAppendLineFormat
    {
        [TestMethod]
        public void AppendLineFormat()
        {
            var @this = new global::System.Text.StringBuilder();

            @this.AppendLineFormat("{0}{1}", "Fizz", "Buzz");

            Assert.AreEqual("FizzBuzz" + global::System.Environment.NewLine, @this.ToString());
        }
    }
}
