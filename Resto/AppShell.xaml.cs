using Resto.Views;

namespace Resto
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage) );
			Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage) );
			Routing.RegisterRoute(nameof(HomePage), typeof(HomePage) );
		}
	}
}
