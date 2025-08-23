using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Resto.Views;

namespace Resto.ViewModel
{
    public partial class SigninViewModel : ObservableObject
    {
        [ICommand]
        async Task Back()
        {
            await Shell.Current.GoToAsync("..");
        }

        [ICommand]
        async void SignIn()
        {
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
    }
}
