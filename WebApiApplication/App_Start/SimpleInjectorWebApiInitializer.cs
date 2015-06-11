#region

using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using WebActivatorEx;
using WebApiApplication;
using WebApiApplication.Core;

#endregion

[assembly: PostApplicationStartMethod(typeof (SimpleInjectorWebApiInitializer), "Initialize")]

namespace WebApiApplication
{

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            container.RegisterWebApiRequest<IContainerRepository, ContainerRepository>();
        }
    }
}