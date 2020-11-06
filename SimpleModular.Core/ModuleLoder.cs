using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleModular.Core
{
    public class ModuleLoder
    {
        private readonly List<Assembly> _assemblies = new List<Assembly>();
        private readonly ModuleConfig _config;
        public ModuleLoder(ModuleConfig config)
        {
            _config = config;
            Load();
        }

        public List<Assembly> Assemblies => _assemblies;

        private void Load()
        {
            var moduleSettings = _config.Setting;

            foreach (var module in moduleSettings.Modules)
            {
                if (module.Enable)
                {
                    var assembly = AssemblyLoadContext.Default
                                                      .LoadFromAssemblyPath(@$"{moduleSettings.Path}\{module.Name}.dll");
                    Assemblies.Add(assembly);
                }
            }
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.BuildServiceProvider();

        //    foreach (var item in _assemblies)
        //    {
        //        var startup = item.GetType($"{item.GetName().Name}.Startup");

        //        if (typeof(IModule).IsAssignableFrom(startup))
        //        {
        //            var module = Activator.CreateInstance(startup) as IModule;
        //            module.ConfigureServices(services);
        //        }
        //    }
        //}
    }

    public class ModuleConfig
    {
        public ModuleSetting Setting { get; private set; }
        public ModuleConfig(IConfiguration config)
        {
            Setting = config.Get<ModuleSetting>();
        }

    }

    public class ModuleSetting
    {
        public string Path { get; set; }
        public IList<Module> Modules { get; set; }
    }

    public class Module
    {
        public string Name { get; set; }
        public bool Enable { get; set; }
    }
}
