using System;
using System.Collections.Generic;
using System.Text;

namespace OnEstEnsemble.Core.Data.Cross.Services.Logging
{
    public interface ILogWrapper
    {
        void Debug(string message);
        void Debug(string message, Exception ex);
        void DebugFormat(string format, params object[] args);
        void Info(string message);
        void Info(string message, Exception ex);
        void InfoFormat(string format, params object[] args);
        void Warn(string message);
        void Warn(string message, Exception ex);
        void WarnFormat(string format, params object[] args);
        void Error(string message);
        void Error(string message, Exception ex);
        void ErrorFormat(string format, params object[] args);
    }
}
