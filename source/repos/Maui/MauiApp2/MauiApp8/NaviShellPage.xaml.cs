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
            _vm.Message = "ようこそ .NET MAUI の世界へ";
            this.BindingContext = _vm;
            // Appクラスに保存しておく
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