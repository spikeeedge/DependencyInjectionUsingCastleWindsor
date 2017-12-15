using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace DependencyInjectionUsingCastleWindsor
{
    public class IoC
    {
        public static void Register()
        {
            var container = new WindsorContainer();

            container.Register(
                Classes.FromThisAssembly()
                .InSameNamespaceAs<Program>(true)
                .WithService
                .DefaultInterfaces()
                .LifestyleTransient());
        }
    }
}
