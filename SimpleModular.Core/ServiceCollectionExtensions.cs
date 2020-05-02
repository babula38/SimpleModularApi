using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleModular.Core
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModuleLoader(this IMvcBuilder builder, IConfiguration config)
        {
            var moduleLoader = new ModuleLoder(new ModuleConfig(config));
            //moduleLoader.Load();

            foreach (var item in moduleLoader.Assemblies)
                builder.AddApplicationPart(item);
        }
    }
}
