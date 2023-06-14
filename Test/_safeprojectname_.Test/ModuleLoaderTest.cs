using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using _safeprojectname_.Core;
using Xunit;

namespace _safeprojectname_.Test
{
    public class ModuleLoaderTest
    {
        [Fact]
        public void Load_should_load_the_right_assembly()
        {
            var dllName = "TestModule";
            var fileInfo = new FileInfo(@$"..\..\..\..\TestModule\bin\Debug\net5.0\{dllName}.dll");
            var moduleLoader = new ModuleLoader(new ModuleConfig(GetConfiguration())
            {
                //Path = fileInfo.FullName
            });

            //moduleLoader.Load();

            //Assert.Equal(assembly.GetName().Name, dllName);
        }

        private IConfiguration GetConfiguration() => new ConfigurationBuilder()
                           .SetBasePath(@"D:\GItHub\_safeprojectname_Api\_safeprojectname_.Test")
                           .AddJsonFile("modules.json")
                           .Build();
    }

    public class TestConfigurationHelper
    {
        public static IConfiguration GetConfiguration()
            => new ConfigurationBuilder()
                .SetBasePath(@"D:\GItHub\_safeprojectname_Api\_safeprojectname_.Test")
                .AddJsonFile("modules.json")
                .Build();
    }
}
