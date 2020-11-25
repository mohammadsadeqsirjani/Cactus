using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Enum
{
    [TestClass]
    public class SystemEnumNotIn
    {
        [TestMethod]
        public void NotIn()
        {
            const Environment.SpecialFolder @this = Environment.SpecialFolder.Desktop;

            var result1 = @this.NotIn(Environment.SpecialFolder.Desktop, Environment.SpecialFolder.DesktopDirectory);
            var result2 = @this.NotIn(Environment.SpecialFolder.DesktopDirectory);

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}
