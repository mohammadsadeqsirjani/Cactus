using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringStripHtml
    {
        [TestMethod]
        public void StripHtml()
        {
            var result1 = "FizzBuzz".StripHtml();
            var result2 = "Fizz<span>Buzz</span>".StripHtml();
            var result3 = "Fizz<span id='toto>' onclick=\"<test></test>\" escapeSingleQuote='\\\'>' escapeDoubleQuote=\"\\\">\">Buzz</span>".StripHtml();

            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzBuzz", result2);
            Assert.AreEqual("FizzBuzz", result3);
        }
    }
}
