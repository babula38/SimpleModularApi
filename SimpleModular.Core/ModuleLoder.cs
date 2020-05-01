using System.Reflection;
using System.Runtime.Loader;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleModular.Core
{
    public class ModuleLoder
    {
        public static Assembly Load()
        {
            string path = @"D:\GItHub\SimpleModularApi\SimpleModular.First\bin\Debug\net5.0\SimpleModular.First.dll";

            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);

            return assembly;
        }
    }
    public static class ServiceCollectionExtensions
    {
        public static void AddModuleLoader(this IMvcBuilder builder)
        {
            builder.AddApplicationPart(ModuleLoder.Load());
        }
    }
}
