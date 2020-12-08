using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringSaveAs
    {
        [TestMethod]
        public void SaveAs()
        {
            var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory ?? string.Empty, "Examples_System_String_SaveAs.txt"));
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory ?? string.Empty, "Examples_System_String_SaveAs2.txt");

            const string @this = "Fizz";

            @this.SaveAs(filePath);
            @this.SaveAs(fileInfo);
            @this.SaveAs(fileInfo, true);

            Assert.IsTrue(fileInfo.Exists);
            Assert.IsTrue(new FileInfo(filePath).Exists);
        }
    }
}
