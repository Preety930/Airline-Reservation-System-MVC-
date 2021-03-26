using ARSREPO;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ARS
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAdmin, AdminRepo>();
            container.RegisterType<IPassengers, PassengersRepo>();
            container.RegisterType<IRoute, RouteRepo>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}