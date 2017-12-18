using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace DependencyInjectionUsingCastleWindsor
{
    public class Container
    {
        private static IWindsorContainer container;

        public static void Register()
        {
            container = new WindsorContainer();

            container.Register(Classes
                .FromThisAssembly()
                .InNamespace("DependencyInjectionUsingCastleWindsor")
                .WithServiceAllInterfaces()
                .LifestyleTransient());
        }

        public static T For<T>()
        {
            return container.Resolve<T>();
        }
    }
}
