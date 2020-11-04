using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimpleModular.Core;
using System;

namespace SImpleModular.Calculator.Add
{
    public class Startup : IModule
    {
        public void Configure(IApplicationBuilder app)
        {
            throw new NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMathService, MathService>();
        }
    }

    public interface IMathService
    {
        int Add(int firstNumber, int secondNumber);
    }
    public class MathService : IMathService
    {
        public int Add(int firstNumber, int secondNumber) => firstNumber + secondNumber;
    }
}
