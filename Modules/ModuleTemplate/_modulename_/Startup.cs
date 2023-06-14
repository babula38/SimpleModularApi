using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using _modulename_.Core;
using System;

namespace _modulename_.Calculator.Add
{
    public class Startup : IModule
    {
        public void Configure(IApplicationBuilder app)
        {
            //throw new NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMathService, MathService>();
        }
    }
}
