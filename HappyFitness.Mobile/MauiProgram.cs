using HappyFitness.Mobile.Pages.Diary;
using HappyFitness.Mobile.Pages.Gym;
using HappyFitness.Mobile.Pages.Profile;
using HappyFitness.Mobile.Pages.Records;
using HappyFitness.Mobile.ViewModels;
using Microsoft.Extensions.Logging;

namespace HappyFitness.Mobile
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
