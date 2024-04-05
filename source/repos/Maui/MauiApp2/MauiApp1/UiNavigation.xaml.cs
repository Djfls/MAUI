namespace MauiApp1;

public partial class UiNavigation : ContentPage
{
	public UiNavigation()
	{
		InitializeComponent();
	}
    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NextPage());
    }
}