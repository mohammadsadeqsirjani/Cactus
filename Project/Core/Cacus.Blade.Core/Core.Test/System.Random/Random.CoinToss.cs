using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Random
{
    [TestClass]
    public class SystemRandomCoinToss
    {
        [TestMethod]
        public void CoinToss()
        {
            var @this = new global::System.Random();

            var value = @this.CoinToss();
        }
    }
}
