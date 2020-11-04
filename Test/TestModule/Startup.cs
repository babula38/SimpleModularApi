using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimpleModular.Core;

namespace TestModule
{
    public class Startup : IModule
    {
        public void Configure(IApplicationBuilder app)
        {
            throw new NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();
        }
    }

    public class TestService
    {
        public string Get() => "Hello from TestService";
    }
}
