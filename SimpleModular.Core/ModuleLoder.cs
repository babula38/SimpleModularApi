using System.Reflection;
using System.Runtime.Loader;

namespace SimpleModular.Core
{
    public class ModuleLoder
    {
        private readonly ModuleLoderConfig _config;
        public ModuleLoder(ModuleLoderConfig config)
        {
            _config = config;
        }
        public Assembly Load()
        {
            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(_config.Path);

            return assembly;
        }
    }

    public class ModuleLoderConfig
    {
        public string Path { get; set; }
    }
}
