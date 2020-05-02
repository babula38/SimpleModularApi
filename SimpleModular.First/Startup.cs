using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimpleModular.Core;
using SimpleModular.First.Services;

namespace SimpleModular.First
{
    public class Startup : IModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MessageService>();
        }
        public void Configure(IApplicationBuilder app)
        {

        }
    }
}
