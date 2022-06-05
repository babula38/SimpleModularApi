using Microsoft.Extensions.DependencyInjection;
using SimpleModular.Core;
using TestModule;
using Xunit;

namespace SimpleModular.Test
{
    public class ModuleServiceRegistrationTest
    {
        [Fact]
        public void Module_should_register_the_service()
        {
            var services = new ServiceCollection();

            var startupModule = new Startup();
            startupModule.ConfigureServices(services);

            var provider = services.BuildServiceProvider();
            var testService = provider.GetRequiredService(typeof(TestService));

            Assert.NotNull(testService);
        }

        [Fact]
        public void Module_loader_should_execute_all_services_of_module()
        {
            var services = new ServiceCollection();

            var moduleLoader = new ModuleLoder(GetModuleConfig());
            //moduleLoader.ConfigureServices(services);

            var provider = services.BuildServiceProvider();
            var testService = provider.GetRequiredService(typeof(TestService));

            Assert.NotNull(testService);
        }

        private ModuleConfig GetModuleConfig()
            => new ModuleConfig(TestConfigurationHelper.GetConfiguration());
    }
}
