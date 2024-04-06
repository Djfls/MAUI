namespace MauiApp2;

public partial class UpdateItemPage : ContentPage
{
	public UpdateItemPage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}