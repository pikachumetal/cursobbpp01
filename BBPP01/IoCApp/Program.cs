using Autofac;
using IoCApp.Biz.Logger;
using IoCApp.Biz.Objects;
using IoCApp.Config;
using System;

namespace IoCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Config Autofac - Composition Root

            var container = Configuration.IoC();
            
            #endregion

            var logger = container.Resolve<ILogger>();
            logger.Log("Hello World!!!");

            //! Correcte - Autofac
            var foo = container.Resolve<Foo>();
            logger.Log(string.Format("The anwser for all is : {0}",foo.Bar()));

            //! Incorrecte - Autofac
            //var foo2 = new Foo(container);
            //logger.Log(string.Format("The anwser for all is : {0}", foo2.Bar()));

            //! POOR MAN's DI
            //var foo3 = MainFactory.CreateFoo();
            //logger.Log(string.Format("The anwser for all is : {0}", foo3.Bar()));

            //! Son iguals dos objectes, s'ha de configurar SingleInstance, o InstancePerRequest Autofac ; sino es Transient
            var foo4 = container.Resolve<Foo>();
            var question = (foo == foo4);
            logger.Log(string.Format("Same Object {0}",question));

            Console.ReadKey();
        }
    }
}
