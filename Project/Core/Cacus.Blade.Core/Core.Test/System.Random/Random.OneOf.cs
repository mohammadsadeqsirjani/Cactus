using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Random
{
    [TestClass]
    public class SystemRandomOneOf
    {
        [TestMethod]
        public void OneOf()
        {
            var @this = new global::System.Random();

            var value1 = @this.OneOf(1, 2, 3, 4);
            var value2 = @this.OneOf("a", "b", "c", "d");
            var value3 = @this.OneOf(1, "a", global::System.DateTime.Now, new object());
        }
    }
}
