using Resto.ViewModel;

namespace Resto.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage(SigninViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}