using Resto.ViewModel;

namespace Resto
{
	public partial class MainPage : ContentPage
	{
		int socount = 0;

		public MainPage(MainViewModel vm)
		{
			InitializeComponent();
			BindingContext = vm;
		}
	}

}
