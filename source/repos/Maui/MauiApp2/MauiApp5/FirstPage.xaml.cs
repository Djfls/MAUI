namespace MauiApp5;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}
	private async void OnCloseClicked() 
	{
		await Navigation.PopModalAsync();
	}
}
