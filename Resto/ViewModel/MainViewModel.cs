

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Resto.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ICommand]
        async void SignInPage()
        {
            await Shell.Current.GoToAsync(nameof(SignInPage));
        }

		[ICommand]
		async void SignUpPage()
		{
			await Shell.Current.GoToAsync(nameof(SignUpPage));
		}
	}
}
