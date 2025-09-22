using HappyFitness.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HappyFitness.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HappyFitnessDbContext>(opt =>
            opt.UseSqlite(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<HappyFitnessDbContext>());

            return services;
        }
    }
}
