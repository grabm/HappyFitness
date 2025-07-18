using HappyFitness.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HappyFitness.MigrationsHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var connectionString = "server=kontakt1.unixstorm.eu;port=3306;database=kontakt1_happyFitness;user=kontakt1_happyFitness;password=VkRCh7JfymjQ2neHXVAK";
                    var serverVersion = new MariaDbServerVersion(new Version(10, 5, 25));

                    services.AddDbContext<HappyFitnessDbContext>(options =>
                    options.UseMySql(connectionString, serverVersion));
                })
                .Build();

            Console.WriteLine("Migration host has been configured successfully. EF Core tools can now be used.");
        }
    }
}
