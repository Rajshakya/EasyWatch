using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWatch.Logger
{
    public interface ILog
    {
        void Information(string message);
        void Warning(string message);
        void Debug(string message);
        void Error(string message);
    }
}
