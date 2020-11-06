using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimpleModular.Core;
using System;

namespace SImpleModular.Calculator.Substract
{
    public class Startup : IModule
    {
        public void Configure(IApplicationBuilder app)
        {
            //throw new NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IMathService, MathService>();
        }
    }
}
