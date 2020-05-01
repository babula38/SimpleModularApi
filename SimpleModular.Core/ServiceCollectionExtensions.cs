using Microsoft.Extensions.DependencyInjection;

namespace SimpleModular.Core
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModuleLoader(this IMvcBuilder builder)
        {
            //builder.AddApplicationPart(ModuleLoder);
        }
    }
}
