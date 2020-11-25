using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderAppendJoin
    {
        [TestMethod]
        public void AppendJoin()
        {
            var list = new List<string> { "Fizz", "Buzz" };

            var @this = new global::System.Text.StringBuilder();

            @this.AppendJoin(",", list.ToArray());

            Assert.AreEqual("Fizz,Buzz", @this.ToString());
        }
    }
}
