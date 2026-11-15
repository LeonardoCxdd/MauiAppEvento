using Microsoft.Extensions.Logging;

namespace MauiAppEvento
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
                    fonts.AddFont("Sora-ExtraLight.ttf", "Sora-ExtraLight");
                    fonts.AddFont("Sora-Light.ttf", "Sora-Light");
                    fonts.AddFont("Sora-Medium.ttf", "Sora-Medium");
                    fonts.AddFont("Sora-Regular.ttf", "Sora-Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
