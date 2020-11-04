using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleModular.Core
{
    public static class ServiceCollectionExtensions
    {
        public static IMvcBuilder AddModules(this IMvcBuilder builder, IServiceCollection services, IConfiguration config)
        {
            var moduleLoader = new ModuleLoder(new ModuleConfig(config));

            foreach (var item in moduleLoader.Assemblies)
            {
                moduleLoader.ConfigureServices(services);
                builder.AddApplicationPart(item);
            }

            return builder;
        }
    }
}
