using Microsoft.Extensions.DependencyInjection;
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

            var startupModule = new StartUp();
            startupModule.ConfigureServices(services);

            var provider = services.BuildServiceProvider();
            var testService = provider.GetRequiredService(typeof(TestService));
            
            Assert.NotNull(testService);
        }
    }
}
