// Import the necessary namespace for using the Microsoft.Extensions.Logging package.
using Microsoft.Extensions.Logging;

// The namespace for the MAUISqlite application.
namespace MAUISqlite
{
    // A static class for the Maui program.
    public static class MauiProgram
    {
        // The main method that creates and configures the Maui app.
        public static MauiApp CreateMauiApp()
        {
            // Create a new Maui app builder instance.
            var builder = MauiApp.CreateBuilder();

            // Use the App class as the startup entry point for the app.
            builder.UseMauiApp<App>()

            // Configure custom fonts for the app.
            .ConfigureFonts(fonts =>
            {
                // Add the "OpenSans-Regular.ttf" font with the alias "OpenSansRegular".
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                
                // Add the "OpenSans-Semibold.ttf" font with the alias "OpenSansSemibold".
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
            // Add a debug logging provider if the DEBUG preprocessor symbol is defined.
            builder.Logging.AddDebug();
#endif

            // Build and return the configured MauiApp instance.
            return builder.Build();
        }
    }
}
