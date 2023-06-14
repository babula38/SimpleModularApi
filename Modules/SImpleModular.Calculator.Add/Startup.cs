using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using _safeprojectname_.Core;
using System;

namespace _safeprojectname_.Calculator.Add
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
