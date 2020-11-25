using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRepeat
    {
        [TestMethod]
        public void Repeat()
        {
            const string @this = "Fizz";

            var value = @this.Repeat(3);

            Assert.AreEqual("FizzFizzFizz", value);
        }
    }
}
