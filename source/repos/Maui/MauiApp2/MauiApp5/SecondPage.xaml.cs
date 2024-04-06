using Xamarin.Google.Crypto.Tink.Proto;

namespace MauiApp5;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}
	private async void OnCloseClicked(object sender, EventArgs e) 
	{
		await Navigation.PopModalAsync();
	}
}