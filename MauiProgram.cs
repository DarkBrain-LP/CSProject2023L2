using CSProject2023L2.Services;
using CSProject2023L2.Services.Contract;
using CSProject2023L2.ViewModels;
using CSProject2023L2.Views;
using Microsoft.Extensions.Logging;

namespace CSProject2023L2;

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

		builder.Services.AddSingleton<LoginView>();
		builder.Services.AddSingleton<LoginViewModel>();
		builder.Services.AddSingleton<HttpClient>();
		builder.Services.AddSingleton<ILoginService, LoginService>();

		return builder.Build();
	}
}
