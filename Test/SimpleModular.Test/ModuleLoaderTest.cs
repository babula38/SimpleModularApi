using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using SimpleModular.Core;
using Xunit;

namespace SimpleModular.Test
{
    public class ModuleLoaderTest
    {
        [Fact]
        public void Load_should_load_the_right_assembly()
        {
            var dllName = "TestModule";
            var fileInfo = new FileInfo(@$"..\..\..\..\TestModule\bin\Debug\net5.0\{dllName}.dll");
            var moduleLoader = new ModuleLoder(new ModuleConfig(GetConfiguration())
            {
                //Path = fileInfo.FullName
            });

            //moduleLoader.Load();

            //Assert.Equal(assembly.GetName().Name, dllName);
        }

        private IConfiguration GetConfiguration() => new ConfigurationBuilder()
                           .SetBasePath(@"D:\GItHub\SimpleModularApi\SimpleModular.Test")
                           .AddJsonFile("modules.json")
                           .Build();
    }

    public class TestConfigurationHelper
    {
        public static IConfiguration GetConfiguration()
            => new ConfigurationBuilder()
                .SetBasePath(@"D:\GItHub\SimpleModularApi\SimpleModular.Test")
                .AddJsonFile("modules.json")
                .Build();
    }
}
