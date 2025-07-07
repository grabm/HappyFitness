using HappyFitness.MAUI.Pages.Diary;
using HappyFitness.MAUI.Pages.Gym;
using HappyFitness.MAUI.Pages.Profile;
using HappyFitness.MAUI.Pages.Records;
using HappyFitness.MAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace HappyFitness.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<GymViewModel>();
            builder.Services.AddTransient<DiaryViewModel>();
            builder.Services.AddTransient<RecordsViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();

            builder.Services.AddTransient<GymPage>();
            builder.Services.AddTransient<DiaryPage>();
            builder.Services.AddTransient<RecordsPage>();
            builder.Services.AddTransient<ProfilePage>();

            return builder.Build();
        }
    }
}
