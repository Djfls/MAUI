namespace MauiApp1;

public partial class UiAnimation : ContentPage
{
	public UiAnimation()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        await imageNet.RotateTo(360, 2000);
        imageNet.Rotation = 45;
    }
}