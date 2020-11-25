using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToFileInfo
    {
        [TestMethod]
        public void ToFileInfo()
        {
            var @this = Path.Combine(AppDomain.CurrentDomain.BaseDirectory ?? string.Empty, "Examples_System_String_ToFileInfo.txt");

            var value = @this.ToFileInfo();

            Assert.AreEqual(@this, value.FullName);
        }
    }
}
