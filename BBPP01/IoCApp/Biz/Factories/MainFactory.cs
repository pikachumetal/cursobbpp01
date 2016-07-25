using IoCApp.Biz;
using IoCApp.Biz.Logger;
using IoCApp.Biz.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp
{
    /// <summary>
    /// POOR MAN's DI
    /// </summary>
    static class MainFactory
    {
        public static ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }

        public static Foo CreateFoo()
        {
            return new Foo(CreateLogger());
        }
    }
}
