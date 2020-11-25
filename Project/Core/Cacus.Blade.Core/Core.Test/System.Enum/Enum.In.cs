using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Enum
{
    [TestClass]
    public class SystemEnumIn
    {
        [TestMethod]
        public void In()
        {
            const Environment.SpecialFolder @this = Environment.SpecialFolder.Desktop;

            var result1 = @this.In(Environment.SpecialFolder.Desktop, Environment.SpecialFolder.DesktopDirectory);
            var result2 = @this.In(Environment.SpecialFolder.DesktopDirectory);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
