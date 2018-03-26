using Autofac;
using Autofac.Integration.WebApi;
using NineService.DAL;
using System.Reflection;
using System.Web.Http;

namespace NineService.App_Start
{
    public class IocConfig
    {
        public static void Configure()
        {
            // Autofac configurations
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerRequest();            

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}