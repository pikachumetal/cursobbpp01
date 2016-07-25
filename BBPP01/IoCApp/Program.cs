using Autofac;
using IoCApp.Biz;
using IoCApp.Biz.Logger;
using System;

namespace IoCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Config Autofac

            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleLogger>().As<ILogger>();
            builder.RegisterType<Foo>();

            var container = builder.Build();
            
            #endregion

            var logger = container.Resolve<ILogger>();
            logger.Log("Hello World!!!");

            //Correcte
            var foo = container.Resolve<Foo>();
            logger.Log(string.Format("The anwser for all is : {0}",foo.Bar()));
            
            ////Incorrecte
            //var foo2 = new Foo(container);
            //logger.Log(string.Format("The anwser for all is : {0}", foo2.Bar()));

            Console.ReadKey();
        }
    }
}
