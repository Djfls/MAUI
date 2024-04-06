using MauiApp8.ViewModel;

namespace MauiApp8;

public partial class NaviShellPage : ContentPage
{
	public NaviShellPage()
	{
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new NaviShellPageViewModel();
            _vm.Message = "ÇÊÇ§Ç±Çª .NET MAUI ÇÃê¢äEÇ÷";
            this.BindingContext = _vm;
            // AppÉNÉâÉXÇ…ï€ë∂ÇµÇƒÇ®Ç≠
            (App.Current as App).NaviShellPageViewModel = _vm;
        };
    }
    NaviShellPageViewModel _vm;

    private async void OnFirstClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//first");
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//second");
    }
    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }
}