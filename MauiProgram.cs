﻿using Microsoft.Extensions.Logging;

namespace Headstarter;

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
				fonts.AddFont("Boldnose-Regular.ttf", "Boldnose");
				fonts.AddFont("Barriecito-Regular.ttf", "Barriecito");
				fonts.AddFont("LilitaOne-Regular.ttf", "LilitaOne");
                fonts.AddFont("materialdesignicons-webfont.ttf", "icons");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
