using HappyFitness.Application.Workouts.Queries;
using HappyFitness.Mobile.Pages.Diary;
using HappyFitness.Mobile.Pages.Gym;
using HappyFitness.Mobile.Pages.Profile;
using HappyFitness.Mobile.Pages.Records;
using HappyFitness.Mobile.ViewModels;
using Microsoft.Extensions.Logging;
using HappyFitness.Infrastructure;
using CommunityToolkit.Maui;

namespace HappyFitness.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(GetWorkoutHistoryQuery).Assembly));

            //DB
            var connectionString = "server=kontakt1.unixstorm.eu;port=3306;database=kontakt1_happyFitness;user=kontakt1_happyFitness;password=niepodam";
            builder.Services.AddInfrastructureServices(connectionString);

            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<GymViewModel>();
            builder.Services.AddTransient<DiaryViewModel>();
            builder.Services.AddTransient<RecordsViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();

            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<GymPage>();
            builder.Services.AddTransient<DiaryPage>();
            builder.Services.AddTransient<RecordsPage>();
            builder.Services.AddTransient<ProfilePage>();

            return builder.Build();
        }
    }
}
