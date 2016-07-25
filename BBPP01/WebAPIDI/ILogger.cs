using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDI
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}