namespace EmptyCollectionViewBug;

public partial class MainPage : ContentPage
{
	

	public MainPage(ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}

