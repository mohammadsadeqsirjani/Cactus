using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Enum
{
    [TestClass]
    public class SystemEnumGetCustomAttributeDescription
    {



        [TestMethod]
        public void GetCustomAttributeDescription()
        {
            const TestEnum @this = TestEnum.A;

            var result = @this.GetCustomAttributeDescription();

            Assert.AreNotEqual("Test Description", result);
        }
    }


    public enum TestEnum
    {
        A,
        B,
        C,
        D
    }
}
