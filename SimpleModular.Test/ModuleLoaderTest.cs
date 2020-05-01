using System;
using System.IO;
using System.Reflection;
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
            var moduleLoader = new ModuleLoder(new ModuleLoderConfig { Path = fileInfo.FullName });

            var assembly = moduleLoader.Load();

            Assert.Equal(assembly.GetName().Name, dllName);
        }
    }
}
