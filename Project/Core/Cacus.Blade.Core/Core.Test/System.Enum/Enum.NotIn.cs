using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Enum
{
    [TestClass]
    public class SystemEnumNotIn
    {
        [TestMethod]
        public void NotIn()
        {
            const TestEnum @this = TestEnum.A;

            var result1 = @this.NotIn(TestEnum.D, TestEnum.B);
            var result2 = @this.NotIn(TestEnum.A);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
