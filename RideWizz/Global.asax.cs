using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Data.Repositories;
using WebGrease.Configuration;

namespace RideWizz {

    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // register dependency injection
            var windsorContainer = new WindsorContainer();
            windsorContainer.Register(Classes
                .FromThisAssembly()
                .Pick().If(t => t.Name.EndsWith("Controller"))
                .LifestylePerWebRequest()
            );
            windsorContainer.Register(Classes
                .FromAssemblyContaining<ICarRepository>()
                .Pick().If(t => t.Name.EndsWith("Repository"))
                .WithServiceFirstInterface()
                .LifestylePerWebRequest()
            );
            DependencyResolver.SetResolver(new WindsorDependencyResolver(windsorContainer));
        }
    }

    class WindsorDependencyResolver : IDependencyResolver {

        readonly IWindsorContainer container;

        public WindsorDependencyResolver(IWindsorContainer container) {
            this.container = container;
        }

        public object GetService(Type t) {
            return container.Kernel.HasComponent(t) ? container.Resolve(t) : null;
        }

        public IEnumerable<object> GetServices(Type t) {
            return container.ResolveAll(t).Cast<object>().ToArray();
        }
    }
}
