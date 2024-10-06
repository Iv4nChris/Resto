using Resto.ViewModel;

namespace Resto
{
	public partial class MainPage : ContentPage
	{

		public MainPage(MainViewModel vm)
		{
			InitializeComponent();
			BindingContext = vm;
		}
	}

}
