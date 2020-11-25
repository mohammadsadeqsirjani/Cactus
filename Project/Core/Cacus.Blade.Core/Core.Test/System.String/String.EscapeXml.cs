using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringEscapeXml
    {
        [TestMethod]
        public void EscapeXml()
        {
            const string @this = "<node>it's my \"node\" & i like it<node>";

            var result = @this.EscapeXml();

            Assert.AreEqual("&lt;node&gt;it&apos;s my &quot;node&quot; &amp; i like it&lt;node&gt;", result);
        }
    }
}
