using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToDirectoryInfo
    {
        [TestMethod]
        public void ToDirectoryInfo()
        {
            var @this = AppDomain.CurrentDomain.BaseDirectory;

            var value = @this.ToDirectoryInfo();

            Assert.AreEqual(@this, value.FullName);
        }
    }
}
