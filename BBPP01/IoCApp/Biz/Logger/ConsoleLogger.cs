using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp.Biz.Logger
{
    class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
