using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace SimpleModular.Core
{
    public static class ServiceCollectionExtensions
    {
        public static IMvcBuilder AddModules(this IMvcBuilder builder, IServiceCollection services, IConfiguration config)
        {
            //services.BuildServiceProvider();
            var moduleLoader = new ModuleLoder(new ModuleConfig(config));


            foreach (var assembly in moduleLoader.Assemblies)
            {
                ConfigureServices(services, assembly);
                //moduleLoader.ConfigureServices(services);
                builder.AddApplicationPart(assembly);
            }

            return builder;
        }

        private static void ConfigureServices(IServiceCollection services, Assembly assembly)
        {
            var startup = assembly.GetType($"{assembly.GetName().Name}.Startup");
            //assembly.GetTypes().SingleOrDefault(x =>
            //{
            //    return x.IsAssignableFrom(typeof(IModule));

            //});
            if (typeof(IModule).IsAssignableFrom(startup))
            {
                var module = System.Activator.CreateInstance(startup) as IModule;
                services.AddSingleton(typeof(IModule), module);
                module.ConfigureServices(services);
            }
        }
    }
}
