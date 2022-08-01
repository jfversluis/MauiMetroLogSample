using MetroLog.MicrosoftExtensions;

namespace MauiMetroLogSample;

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

		builder.Logging.AddTraceLogger(_ => { });
		builder.Logging.AddInMemoryLogger(_ => { });
		builder.Logging.AddStreamingFileLogger(_ => { });
        builder.Services.AddTransient<MainPage>();

		return builder.Build();
	}
}
