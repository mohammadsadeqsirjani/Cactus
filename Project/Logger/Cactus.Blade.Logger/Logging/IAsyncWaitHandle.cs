using System;
using System.Threading;
using System.Threading.Tasks;

namespace Logging
{
    public interface IAsyncWaitHandle : IDisposable
    {
        Task WaitAsync(
            int millisecondsTimeout = Timeout.Infinite,
            CancellationToken cancellationToken = default);

        void Release(int releaseCount = 1);
    }
}
