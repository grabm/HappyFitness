using HappyFitness.Domain.Workouts;
using HappyFitness.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HappyFitness.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //var dbPath = Path.Combine(FileSystem.AppDataDirectory, "happyfitness.db");

            string cs = configuration.GetConnectionString("Default");
            services.AddDbContext<HappyFitnessDbContext>(opt =>
            //opt.UseSqlite(configuration.GetConnectionString("Default")));
            opt.UseSqlite(configuration.GetConnectionString("happyfitness.db")));

            //services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<HappyFitnessDbContext>());
            services.AddTransient<IWorkoutSessionRepository, WorkoutSessionRepository>();
            return services;
        }
    }
}
