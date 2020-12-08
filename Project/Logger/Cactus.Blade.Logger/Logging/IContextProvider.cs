using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public interface IContextProvider
    {
        void AddContextData(ILogEntry logEntry);
    }
}
