﻿using Maui.FreakyUXKit;
using CommunityToolkit.Maui;
using Maui.FreakyControls.Extensions;
namespace Samples;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		})
		.UseFreakyUXKit()
		.UseMauiCommunityToolkit()
		.InitializeFreakyControls();
        return builder.Build();
    }
}