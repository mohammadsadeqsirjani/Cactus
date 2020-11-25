using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderAppendLineJoin
    {
        [TestMethod]
        public void AppendLineFormat()
        {
            var list = new List<string> { "Fizz", "Buzz" };

            var @this = new global::System.Text.StringBuilder();

            @this.AppendLineJoin(",", list);

            Assert.AreEqual("Fizz,Buzz" + "\n", @this.ToString());
        }
    }
}
