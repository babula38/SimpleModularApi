using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace _safeprojectname_.Core
{
    public interface IModule
    {
        void ConfigureServices(IServiceCollection services);
        void Configure(IApplicationBuilder app);
    }
}
