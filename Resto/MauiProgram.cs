using Microsoft.Extensions.Logging;
using Resto.ViewModel;
using Resto.Views;

namespace Resto
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

					fonts.AddFont("Poppins-Bold.ttf", "PBold");
					fonts.AddFont("Poppins-Light.ttf", "PLight");
					fonts.AddFont("Poppins-Regular.ttf", "PRegular");
					fonts.AddFont("Poppins-Medium.ttf", "PMedium");
					fonts.AddFont("Poppins-Thin.ttf", "PThin");

					fonts.AddFont("FontBrands.otf", "Brands");
					fonts.AddFont("FontSolid.otf", "Solid");
				});





			builder.Services.AddSingleton<MainPage>();
			builder.Services.AddSingleton<MainViewModel>();

			builder.Services.AddSingleton<SignInPage>();
			builder.Services.AddSingleton<SigninViewModel>();

			builder.Services.AddSingleton<SignUpPage>();
			builder.Services.AddSingleton<SignupViewModel>();

			builder.Services.AddTransient<HomePage>();
			builder.Services.AddTransient<HomeViewModel>();



#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
