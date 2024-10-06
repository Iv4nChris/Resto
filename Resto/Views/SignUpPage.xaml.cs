using Resto.ViewModel;

namespace Resto.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage(SignupViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private async void OnNext_Clicked(object sender, EventArgs e)
	{
		//Slide the first step to the left
		await FirstStepLayout.TranslateTo(-1000, 0, 200, Easing.SinInOut);

		//call the viewmodel command to the handle logic
		var viewmodel = (SignupViewModel)BindingContext;
		viewmodel.GoToNextSlide();

		// Slide the second step from right to left (on-screen)
		SecondStepLayout.TranslationX = 1000; // Start it off-screen to the right
		await SecondStepLayout.TranslateTo(0, 0, 200, Easing.SinInOut); // Slide in to the center in 500ms
	}

	private async void OnPrevious_Clicked(object sender, EventArgs e)
	{
		//Slide the first step to the left
		await SecondStepLayout.TranslateTo(-1000, 0, 200, Easing.SinInOut);

		//call the viewmodel command to the handle logic
		var viewmodel = (SignupViewModel)BindingContext;
		viewmodel.PreviousSlide();

		// Slide the second step from right to left (on-screen)
		FirstStepLayout.TranslationX = 1000; // Start it off-screen to the right
		await FirstStepLayout.TranslateTo(0, 0, 200, Easing.SinInOut); // Slide in to the center in 500ms
	}
}