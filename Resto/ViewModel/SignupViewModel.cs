using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Resto.ViewModel
{
    public partial class SignupViewModel : ObservableObject
    {

        [ObservableProperty]
        private bool isFirstStepVisible = true;

		[ObservableProperty]
		private bool isSecondStepVisible = false;

		//public SignupViewModel()
		//{
		//	IsFirstStepVisible = true;
		//	IsSecondStepVisible = false;
		//}

        [ICommand]
        public void GoToNextSlide()
        {
			
			IsFirstStepVisible = false;
            IsSecondStepVisible = true;
		}

		[ICommand]
		public void PreviousSlide()
		{
			
			IsFirstStepVisible = true;
			IsSecondStepVisible = false;
		}

		[ICommand]
		async Task Back()
		{
			await Shell.Current.GoToAsync("..");
		}
	}
}
