using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectDeepClone
    {
        [TestMethod]
        public void DeepClone()
        {
            var @this = new TestClass { Value = "Fizz" };

            var clone = @this.DeepClone();

            Assert.AreEqual(@this.Value, clone.Value);
        }

        [Serializable]
        public class TestClass
        {
            public string Value;
        }
    }
}
