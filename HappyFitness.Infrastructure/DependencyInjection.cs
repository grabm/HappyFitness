using HappyFitness.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HappyFitness.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            var serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(connectionString));

            services.AddDbContext<HappyFitnessDbContext>(options =>
            options.UseMySql(connectionString, serverVersion));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<HappyFitnessDbContext>());

            return services;
        }
    }
}
