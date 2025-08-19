using HappyFitness.Application.Interfaces;
using HappyFitness.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HappyFitness.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO poprawić tą metodę

            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<HappyFitnessDbContext>(opt =>
            opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            builder.Services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<HappyFitnessDbContext>());

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IApplicationMarker).Assembly));

            builder.Services.AddInfrastructureServices(connectionString);


            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
