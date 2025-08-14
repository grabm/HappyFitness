using HappyFitness.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HappyFitness.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            var serverVersion = new MariaDbServerVersion(new Version(10, 5, 25));

            services.AddDbContext<HappyFitnessDbContext>(options =>
            options.UseMySql(connectionString, serverVersion));
            // This line tells the DI container: "When a class asks for IApplicationDbContext,
            // provide it with the HappyFitnessDbContext instance."
            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<HappyFitnessDbContext>());

            return services;
        }
    }
}
