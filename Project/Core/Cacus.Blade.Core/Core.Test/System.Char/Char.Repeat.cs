using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Char
{
    [TestClass]
    public class CharRepeat
    {
        [TestMethod]
        public void Repeat()
        {
            const char @this = 'F';

            var result = @this.Repeat(3);

            Assert.AreEqual("FFF", result);
        }
    }
}
