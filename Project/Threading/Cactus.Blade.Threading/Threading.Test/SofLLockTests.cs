using Cactus.Blade.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Threading.Test
{
    [TestClass]
    public class SoftLockTests
    {
        [TestMethod("TryAcquire method sets IsLockAcquired property to true")]
        public void TryAcquireTest1()
        {
            var softLock = new SoftLock();

            // Prove that the lock is not acquired initially
            Assert.IsFalse(softLock.IsLockAcquired);

            // This will set the lock to true
            softLock.TryAcquire();

            Assert.IsTrue(softLock.IsLockAcquired);
        }

        [TestMethod("TryAcquire returns true when the lock is acquired")]
        public void TryAcquireTest2()
        {
            var softLock = new SoftLock();

            Assert.IsFalse(softLock.IsLockAcquired);
        }

        [TestMethod("TryAcquire returns false when the lock has already been acquired")]
        public void TryAcquireTest3()
        {
            var softLock = new SoftLock();

            softLock.TryAcquire();

            Assert.IsTrue(softLock.IsLockAcquired);
        }

        [TestMethod("Release method sets IsLockAcquired property back to false")]
        public void ReleaseTest()
        {
            var softLock = new SoftLock();

            softLock.TryAcquire();

            // prove it is locked
            Assert.IsTrue(softLock.IsLockAcquired, "If this failed we have issues in TryAcquire");

            softLock.Release();

            // verify it has been released
            Assert.IsFalse(softLock.IsLockAcquired);
        }
    }
}
