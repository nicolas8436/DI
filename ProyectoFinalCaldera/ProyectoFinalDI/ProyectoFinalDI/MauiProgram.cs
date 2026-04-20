using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace ProyectoFinalDI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionToolkit()//SyncFusion
                .ConfigureFonts(fonts =>//Fuentes
                {
                    fonts.AddFont("OpenSansRegular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSansSemibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("InterBold.ttf", "InterBold");
                    fonts.AddFont("InterRegular.ttf", "Inter");
                    
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
