using Autofac;
using IoCApp.Biz.Logger;
using IoCApp.Biz.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp.Config
{
    static class Configuration
    {
        public static IContainer IoC()
        {
            var builder = new ContainerBuilder();

            //? SingleInstance: fa que sigui sempre el mateix objecte - Singleton - El cicle de vida el controla Autofac
            //? InstancePerRequest: per cada request de MVC WEBAPI sera Singleton
            //? Sense singleinstance cadavegada es un  altre - EL ciclede vida el controlojo - Transient

            builder.RegisterType<ConsoleLogger>().As<ILogger>().SingleInstance();
            builder.RegisterType<Foo>();

            return builder.Build();

        }
    }
}
