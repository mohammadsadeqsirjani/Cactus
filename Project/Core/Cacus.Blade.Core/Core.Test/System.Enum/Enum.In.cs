using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Enum
{
    [TestClass]
    public class SystemEnumIn
    {
        [TestMethod]
        public void In()
        {
            const TestEnum @this = TestEnum.A;

            var result1 = @this.In(TestEnum.A, TestEnum.B);
            var result2 = @this.In(TestEnum.C);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
