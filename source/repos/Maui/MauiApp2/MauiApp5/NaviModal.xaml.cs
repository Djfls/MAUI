namespace MauiApp5;

public partial class NaviModal : ContentPage
{
	public NaviModal()
	{
		InitializeComponent();
	}
	private async void OnFirstClicked(object sender ,EventArgs e) 
	{
		await Navigation.PushModalAsync(new FirstPage());
	}
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SecondPage());
    }
}