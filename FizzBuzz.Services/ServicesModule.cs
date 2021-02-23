using Autofac;
using FizzBuzz.DomainModels.Interfaces;
using System.Linq;

namespace FizzBuzz.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            /* Register all services */
            var type = typeof(IService);
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => type.IsAssignableFrom(t))
                .AsImplementedInterfaces();

        }
    }
}
