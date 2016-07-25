using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using WebAPIDI.Controllers;

namespace WebAPIDI
{
    public static  class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<ILogger>().As<ConsoleLogger>();

            var container = builder.Build();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}