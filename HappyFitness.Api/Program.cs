using HappyFitness.Application.Interfaces;
using HappyFitness.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HappyFitness.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<HappyFitnessDbContext>());

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IApplicationMarker).Assembly));

            builder.Services.AddInfrastructureServices(builder.Configuration);



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
