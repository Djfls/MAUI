namespace MauiApp1;

public partial class UiGrid : ContentPage
{
	public UiGrid()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        string name = textName.Text;
        int age = int.Parse(textAge.Text);
        string addr = textAddress.Text;
        await DisplayAlert(".NET MAUI", $"{name} ({age}) in {addr}", "OK");
    }
}